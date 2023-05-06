using Market.DataAccess.Data;
using Market.DataAccess.Repository.IRepository;
using Market.Models;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;

namespace MarketWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var getObjProducts = _unitOfWork.Product.GetAll().ToList();
            return View(getObjProducts);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Product.Add(obj);
                _unitOfWork.Save();
                TempData["Success"] = "Product Create Successfully";
                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Product? getObjProduct = _unitOfWork.Product.Get(i => i.Id == id);

            if (getObjProduct == null)
            {
                return NotFound();
            }

            return View(getObjProduct);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {   
            if(ModelState.IsValid)
            {
                _unitOfWork.Product.Update(product);
                _unitOfWork.Save();
                TempData["success"] = "Product updated successfully";
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Delete(int? id) 
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Product getObjProduct = _unitOfWork.Product.Get(i => i.Id == id);

            if (getObjProduct == null)
            {
                return NotFound();
            }

            return View(getObjProduct);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int? id)
        {
            Product? product = _unitOfWork.Product.Get(i => i.Id == id);

            if (product == null)
            {
                return NotFound();
            }
            _unitOfWork.Product.Remove(product);
            _unitOfWork.Save();
            TempData["success"] = "Product deleted successfully";
            return RedirectToAction("Index");
        }
    }
}
