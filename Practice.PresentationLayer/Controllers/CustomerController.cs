using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Practice.BusinessLogicLayer.Data;
using Practice.DataAccessLayer.Entities;

namespace Practice.PresentationLayer.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository _context;

        public CustomerController(ICustomerRepository context)
        {
            _context = context;
        }

        // GET: Customer
        public async Task<IActionResult> List()
        {
            return View(_context.GetAllCustomers());
        }

        // GET: Customer/Details/5
        public async Task<IActionResult> Details(int id)
        {
            
            return View(_context.GetCustomerById(id));
        }

        // GET: Customer/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] Customer customer)
        {
            _context.AddCustomer(customer);
            return RedirectToAction(nameof(List));
        }

        // GET: Customer/Edit/5
        public async Task<IActionResult> Edit(Customer customer)
        {
            return View(_context.GetCustomerById(customer.Id));
        }

        // POST: Customer/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] Customer customer)
        {

            _context.UpdateCustomer(customer);
            return RedirectToAction(nameof(List));
        }

        // GET: Customer/Delete/5
        public async Task<IActionResult> Delete(Customer customer)
        {
            return View(_context.GetCustomerById(customer.Id));
        }

        // POST: Customer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Customer customer)
        {
            _context.DeleteCustomer(customer);
            return RedirectToAction(nameof(List));
        }

        
    }
}
