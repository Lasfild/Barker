using Barker.DataAccess.Repository.IRepository;
using Barker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.Linq;

namespace Barker.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _environment;

        public CategoryController(IUnitOfWork unitOfWork, IWebHostEnvironment environment)
        {
            _unitOfWork = unitOfWork;
            _environment = environment;
        }

        public IActionResult Index()
        {
            var categories = _unitOfWork.Category.GetAll().ToList();
            return View(categories);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CategoryModel category)
        {
            if (ModelState.IsValid)
            {
                string categoryFolder = Path.Combine(_environment.WebRootPath, "img", "category_Img", category.Name);
                if (!Directory.Exists(categoryFolder))
                {
                    Directory.CreateDirectory(categoryFolder);
                }

                if (category.ImgFile != null)
                {
                    string extension = Path.GetExtension(category.ImgFile.FileName);
                    string newFileName = $"{DateTime.Now:yyyyMMddHHmmssff}{extension}";
                    string filePath = Path.Combine(categoryFolder, newFileName);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        category.ImgFile.CopyTo(stream);
                    }

                    category.Img = $"/img/category_Img/{category.Name}/{newFileName}";
                }

                _unitOfWork.Category.Add(category);
                _unitOfWork.Save();
                TempData["success"] = "Category created successfully";
                return RedirectToAction("Index");
            }
            return View(category);
        }

        public IActionResult Edit(int id)
        {
            var category = _unitOfWork.Category.Get(u => u.Id == id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(CategoryModel category)
        {
            if (ModelState.IsValid)
            {
                var existingCategory = _unitOfWork.Category.Get(u => u.Id == category.Id);
                if (existingCategory == null)
                {
                    return NotFound();
                }

                bool isNameChanged = !string.Equals(existingCategory.Name, category.Name, StringComparison.OrdinalIgnoreCase);
                string oldCategoryFolder = Path.Combine(_environment.WebRootPath, "img", "category_Img", existingCategory.Name);
                string newCategoryFolder = Path.Combine(_environment.WebRootPath, "img", "category_Img", category.Name);

                if (isNameChanged)
                {
                    if (Directory.Exists(oldCategoryFolder))
                    {
                        Directory.Move(oldCategoryFolder, newCategoryFolder);
                    }

                    if (!string.IsNullOrEmpty(existingCategory.Img))
                    {
                        existingCategory.Img = existingCategory.Img.Replace($"/img/category_Img/{existingCategory.Name}/", $"/img/category_Img/{category.Name}/");
                    }
                }

                if (category.ImgFile != null)
                {
                    if (!Directory.Exists(newCategoryFolder))
                    {
                        Directory.CreateDirectory(newCategoryFolder);
                    }

                    string extension = Path.GetExtension(category.ImgFile.FileName);
                    string newFileName = $"{DateTime.Now:yyyyMMddHHmmssff}{extension}";
                    string filePath = Path.Combine(newCategoryFolder, newFileName);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        category.ImgFile.CopyTo(stream);
                    }

                    if (!string.IsNullOrEmpty(existingCategory.Img))
                    {
                        string oldFilePath = Path.Combine(_environment.WebRootPath, existingCategory.Img.TrimStart('/'));
                        if (System.IO.File.Exists(oldFilePath))
                        {
                            System.IO.File.Delete(oldFilePath);
                        }
                    }

                    existingCategory.Img = $"/img/category_Img/{category.Name}/{newFileName}";
                }

                existingCategory.Name = category.Name;
                existingCategory.Description = category.Description;

                _unitOfWork.Category.Update(existingCategory);
                _unitOfWork.Save();
                TempData["success"] = "Category updated successfully";
                return RedirectToAction("Index");
            }
            return View(category);
        }

        public IActionResult Delete(int id)
        {
            var category = _unitOfWork.Category.Get(u => u.Id == id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int id)
        {
            var category = _unitOfWork.Category.Get(u => u.Id == id);
            if (category == null)
            {
                return NotFound();
            }

            var newCategoryId = _unitOfWork.Category.GetAll()
                .Where(c => c.Id != id)
                .OrderBy(c => c.Id)
                .FirstOrDefault()?.Id;

            if (newCategoryId != null)
            {
                var products = _unitOfWork.Product.GetAll(p => p.CategoryId == id).ToList();
                foreach (var product in products)
                {
                    product.CategoryId = newCategoryId.Value;
                    _unitOfWork.Product.Update(product);
                }
            }

            string categoryFolder = Path.Combine(_environment.WebRootPath, "img", "category_Img", category.Name);
            if (Directory.Exists(categoryFolder))
            {
                Directory.Delete(categoryFolder, true);
            }

            _unitOfWork.Category.Remove(category);
            _unitOfWork.Save();
            TempData["success"] = "Category deleted successfully";
            return RedirectToAction("Index");
        }
    }
}
