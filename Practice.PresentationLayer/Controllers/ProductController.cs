using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Practice.BusinessLogicLayer.Models;
using Practice.DataAccessLayer.Entities;

namespace Practice.PresentationLayer.Controllers
{
    public class ProductController : Controller
    {
        private readonly IGenericRepository<Product> _repository;
        public ProductController(IGenericRepository<Product> repository)
        {
            _repository = repository;
        }

        // GET: ProductController
        public ActionResult List()
        {
            return View(_repository.GetAll());
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            return View(_repository.GetById(id));
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
                _repository.Add(product);
                return RedirectToAction(nameof(List));
            }
            catch(Exception ex) 
            {
                return View($"Error: {ex.Message}");
            }
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_repository.GetById(id));
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Product product)
        {
            try
            {
                _repository.Update(product);
                return RedirectToAction(nameof(List));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Delete/5
        [HttpGet]
        public ActionResult Delete(Product product)
        {
            return View(_repository.GetById(product.Id));
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int ID, Product product)
        {
            try
            {
                _repository.Delete(product);
                return RedirectToAction(nameof(List));
            }
            catch(Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }
        }
    }
}
