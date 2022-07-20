using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BusinessObject;
using DataAccess;
using DataAccess.Repository;
using System;
using System.Linq;

namespace eStore.Controllers
{
    public class ProductController : Controller
    {
        IProductRepository productRepository = null;

        public ProductController() => productRepository = new ProductRepository();

        // GET: ProductController
        public ActionResult Index(string? searchName, string? searchPrice)
        {
            var productList = productRepository.GetProducts();
            decimal priceMin = 0;
            decimal priceMax = decimal.MaxValue;
            switch (searchPrice)
            {
                case "1":
                    priceMin = 0;
                    priceMax = 50;
                    break;
                case "2":
                    priceMin = 51;
                    priceMax = 100;
                    break;
                case "3":
                    priceMin = 101;
                    priceMax = decimal.MaxValue;
                    break;
                default:
                    priceMin = 0;
                    priceMax = decimal.MaxValue;
                    break;
            }
            if (!string.IsNullOrEmpty(searchName))
            {
                productList = productList.Where(p => p.ProductName.Contains(searchName));
            }

            productList = productList.Where(p => p.UnitPrice >= priceMin && p.UnitPrice <= priceMax);

            ViewBag.SearchName = searchName;
            ViewBag.SearchPrice = searchPrice;
            return View(productList);
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var product = productRepository.GetProduct(id.Value);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    productRepository.InsertProduct(product);
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View(product);
            }
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var product = productRepository.GetProduct(id.Value);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Product product)
        {
            try
            {
                if (id != product.ProductId)
                {
                    return NotFound();
                }
                if (ModelState.IsValid)
                {
                    productRepository.UpdateProduct(product);
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View(product);
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var product = productRepository.GetProduct(id.Value);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                productRepository.DeleteProduct(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }
    }
}
