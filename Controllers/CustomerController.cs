using Microsoft.AspNetCore.Mvc;
using GarasiMobil.Models;
using GarasiMobil.Services;

namespace GarasiMobil.Controllers
{
    public class CustomerController : Controller
    {
        private readonly CustomerService _service;

        public CustomerController()
        {
            _service = new CustomerService();
        }

        public IActionResult Index()
        {
            var customers = _service.Get();
            return View(customers);
        }

        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            customer.TanggalDaftar = DateTime.Now;
            _service.Create(customer);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(string id)
        {
            var customer = _service.Get(id);
            return View(customer);
        }

        [HttpPost]
        public IActionResult Edit(string id, Customer customer)
        {
            _service.Update(id, customer);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(string id)
        {
            _service.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
