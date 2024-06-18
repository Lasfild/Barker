using Barker.DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Barker.Models;
using System;

namespace Barker.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _environment;

        public ProductController(IUnitOfWork unitOfWork, IWebHostEnvironment environment)
        {
            _unitOfWork = unitOfWork;
            _environment = environment;
        }

        public IActionResult Index()
        {
            List<ProductModel> objProductList = _unitOfWork.Product.GetAll().ToList();
            return View(objProductList);
        }

        public IActionResult Create()
        {
            var product = new ProductModel
            {
                Categories = _unitOfWork.Category.GetAll().ToList()
            };
            return View(product);
        }

        [HttpPost]
        public IActionResult Create(ProductModel product)
        {
            if (ModelState.IsValid)
            {
                var imagePaths = new List<string>();
                if (product.ImgFiles != null)
                {
                    string productFolder = Path.Combine(_environment.WebRootPath, "img", "product_Img", product.Name);
                    if (!Directory.Exists(productFolder))
                    {
                        Directory.CreateDirectory(productFolder);
                    }

                    foreach (var image in product.ImgFiles)
                    {
                        if (image != null && image.Length > 0)
                        {
                            string randomDigits = new Random().Next(100, 1000).ToString(); // Генерация трех случайных цифр
                            string newFileName = DateTime.Now.ToString("yyyyMMddHHmmssff") + randomDigits + Path.GetExtension(image.FileName);
                            string imageFullPath = Path.Combine(productFolder, newFileName);

                            using (var stream = new FileStream(imageFullPath, FileMode.Create))
                            {
                                image.CopyTo(stream);
                            }

                            imagePaths.Add($"/img/product_Img/{product.Name}/{newFileName}");
                        }
                    }
                }

                product.Img = imagePaths;
                _unitOfWork.Product.Add(product);
                _unitOfWork.Save();
                TempData["success"] = "Product created successfully";
                return RedirectToAction("Index");
            }
            product.Categories = _unitOfWork.Category.GetAll().ToList();
            return View(product);
        }

        public IActionResult Edit(int id)
        {
            var product = _unitOfWork.Product.Get(u => u.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            product.Categories = _unitOfWork.Category.GetAll().ToList();
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(ProductModel product)
        {
            if (ModelState.IsValid)
            {
                // Получаем старую версию продукта из базы данных
                var existingProduct = _unitOfWork.Product.Get(u => u.Id == product.Id);
                if (existingProduct == null)
                {
                    return NotFound();
                }

                var imagePaths = existingProduct.Img;

                // Если есть новые изображения, удаляем старые и добавляем новые
                if (product.ImgFiles != null && product.ImgFiles.Any())
                {
                    // Удаление старых изображений
                    string productFolder = Path.Combine(_environment.WebRootPath, "img", "product_Img", existingProduct.Name);
                    if (Directory.Exists(productFolder))
                    {
                        Directory.Delete(productFolder, true); // true позволяет рекурсивное удаление всех файлов и подкаталогов
                    }

                    // Создание новой папки для изображений, если она не существует
                    if (!Directory.Exists(productFolder))
                    {
                        Directory.CreateDirectory(productFolder);
                    }

                    // Добавление новых изображений
                    imagePaths = new List<string>();
                    foreach (var image in product.ImgFiles)
                    {
                        if (image != null && image.Length > 0)
                        {
                            string randomDigits = new Random().Next(100, 1000).ToString(); // Генерация трех случайных цифр
                            string newFileName = DateTime.Now.ToString("yyyyMMddHHmmssff") + randomDigits + Path.GetExtension(image.FileName);
                            string imageFullPath = Path.Combine(productFolder, newFileName);

                            using (var stream = new FileStream(imageFullPath, FileMode.Create))
                            {
                                image.CopyTo(stream);
                            }

                            imagePaths.Add($"/img/product_Img/{product.Name}/{newFileName}");
                        }
                    }
                }

                // Обновление данных продукта
                existingProduct.Name = product.Name;
                existingProduct.Description = product.Description;
                existingProduct.Img = imagePaths;
                existingProduct.Price = product.Price;
                existingProduct.VendorCode = product.VendorCode;
                existingProduct.IsAvailable = product.IsAvailable;
                existingProduct.IsOnSale = product.IsOnSale;
                existingProduct.Style = product.Style;
                existingProduct.Shoe = product.Shoe;
                existingProduct.Fullness = product.Fullness;
                existingProduct.SoleMethod = product.SoleMethod;
                existingProduct.Sole = product.Sole;
                existingProduct.Country = product.Country;
                existingProduct.TopMaterial = product.TopMaterial;
                existingProduct.Size = product.Size;
                existingProduct.Color = product.Color;
                existingProduct.CategoryId = product.CategoryId;

                _unitOfWork.Product.Update(existingProduct);
                _unitOfWork.Save();
                TempData["success"] = "Product updated successfully";
                return RedirectToAction("Index");
            }
            product.Categories = _unitOfWork.Category.GetAll().ToList();
            return View(product);
        }

        public IActionResult Delete(int id)
        {
            var product = _unitOfWork.Product.Get(u => u.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int id)
        {
            var product = _unitOfWork.Product.Get(u => u.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            string productFolder = Path.Combine(_environment.WebRootPath, "img", "product_Img", product.Name);
            if (Directory.Exists(productFolder))
            {
                Directory.Delete(productFolder, true);
            }

            _unitOfWork.Product.Remove(product);
            _unitOfWork.Save();
            TempData["success"] = "Product deleted successfully";
            return RedirectToAction("Index");
        }
    }
}
