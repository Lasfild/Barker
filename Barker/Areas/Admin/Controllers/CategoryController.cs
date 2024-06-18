using Barker.DataAccess.Repository.IRepository;
using Barker.Models;
using Microsoft.AspNetCore.Mvc;

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
            List<CategoryModel> objCategoryList = _unitOfWork.Category.GetAll().ToList();
            return View(objCategoryList);
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
                if (category.ImgFile != null)
                {
                    string categoryFolder = Path.Combine(_environment.WebRootPath, "img", "category_img");
                    if (!Directory.Exists(categoryFolder))
                    {
                        Directory.CreateDirectory(categoryFolder);
                    }

                    string newFileName = DateTime.Now.ToString("yyyyMMddHHmmssff") + Path.GetExtension(category.ImgFile.FileName);
                    string imageFullPath = Path.Combine(categoryFolder, newFileName);

                    using (var stream = new FileStream(imageFullPath, FileMode.Create))
                    {
                        category.ImgFile.CopyTo(stream);
                    }

                    category.Img = $"/img/category_img/{newFileName}";
                }

                _unitOfWork.Category.Add(category);
                _unitOfWork.Save();
                TempData["success"] = "Category created successfully";
                return RedirectToAction("Index");
            }
            return View(category);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            CategoryModel? categoryFromDb = _unitOfWork.Category.Get(u => u.Id == id);
            if (categoryFromDb == null)
            {
                return NotFound();
            }
            return View(categoryFromDb);
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

                if (category.ImgFile != null)
                {
                    string categoryFolder = Path.Combine(_environment.WebRootPath, "img", "category_img");

                    // Удаление старого изображения, если оно существует
                    if (!string.IsNullOrEmpty(existingCategory.Img))
                    {
                        string oldImagePath = Path.Combine(_environment.WebRootPath, existingCategory.Img.TrimStart('/'));
                        if (System.IO.File.Exists(oldImagePath))
                        {
                            System.IO.File.Delete(oldImagePath);
                        }
                    }

                    string newFileName = DateTime.Now.ToString("yyyyMMddHHmmssff") + Path.GetExtension(category.ImgFile.FileName);
                    string imageFullPath = Path.Combine(categoryFolder, newFileName);

                    using (var stream = new FileStream(imageFullPath, FileMode.Create))
                    {
                        category.ImgFile.CopyTo(stream);
                    }

                    category.Img = $"/img/category_img/{newFileName}";
                }

                // Обновление данных категории
                existingCategory.Name = category.Name;
                existingCategory.Description = category.Description;
                existingCategory.Img = category.Img ?? existingCategory.Img;

                _unitOfWork.Category.Update(existingCategory);
                _unitOfWork.Save();
                TempData["success"] = "Category edited successfully";
                return RedirectToAction("Index");
            }
            return View(category);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            CategoryModel? categoryFromDb = _unitOfWork.Category.Get(u => u.Id == id);
            if (categoryFromDb == null)
            {
                return NotFound();
            }
            return View(categoryFromDb);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int? id)
        {
            CategoryModel? category = _unitOfWork.Category.Get(u => u.Id == id);
            if (category == null)
            {
                return NotFound();
            }

            // Удаление изображения
            if (!string.IsNullOrEmpty(category.Img))
            {
                string imagePath = Path.Combine(_environment.WebRootPath, category.Img.TrimStart('/'));
                if (System.IO.File.Exists(imagePath))
                {
                    System.IO.File.Delete(imagePath);
                }
            }

            _unitOfWork.Category.Remove(category);
            _unitOfWork.Save();
            TempData["success"] = "Category deleted successfully";
            return RedirectToAction("Index");
        }
    }
}

