using AgricultureUI.Models;
using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureUI.Controllers {
    public class ServiceController : Controller {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService) {
            _serviceService = serviceService;
        }


        public IActionResult Deneme(){
            return View();
        }

        public IActionResult Index() {
            var values = _serviceService.TGetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddService() {
            return View(new ServiceAddViewModel());
        }

        [HttpPost]
        public IActionResult AddService(ServiceAddViewModel model) {
            if (ModelState.IsValid) {
                _serviceService.TInsert(new Service() {
                    Title = model.Title,
                    Description = model.Description,
                    Image = model.Image
                });
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult DeleteService(int id) {
            var model = _serviceService.TGetById(id);
            if (model != null) _serviceService.TDelete(model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditService(int id) {
            var value = _serviceService.TGetById(id);
            if (value != null) return View(value);
            return NotFound();
        }

        [HttpPost]
        public IActionResult EditService(Service model) {
            _serviceService.TUpdate(model);
            return RedirectToAction("Index");
        }
    }
}
