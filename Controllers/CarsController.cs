using GarasiMobil.Models;
using GarasiMobil.Services;
using Microsoft.AspNetCore.Mvc;

namespace GarasiMobil.Controllers
{
    public class CarsController : Controller
    {
        private readonly CarService _carService;

        public CarsController(CarService carService)
        {
            _carService = carService;
        }

        public async Task<IActionResult> Index()
        {
            var cars = await _carService.GetAsync();
            return View(cars);
        }

        public IActionResult Create() => View();

        [HttpPost]
        public async Task<IActionResult> Create(Car car)
        {
            await _carService.CreateAsync(car);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(string id)
        {
            var car = await _carService.GetAsync(id);
            if (car == null) return NotFound();
            return View(car);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(string id, Car car)
        {
            await _carService.UpdateAsync(id, car);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(string id)
        {
            await _carService.RemoveAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
