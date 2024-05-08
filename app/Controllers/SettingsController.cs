using application.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace app.Controllers
{
    public class SettingsController : Controller
    {
        private readonly IServiceManager _serviceManager;

        public SettingsController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        public async Task<IActionResult> GetAllProductCategory()
        {
            return View(await _serviceManager.ProductCategoryService.GetAllProductCategoryAsync(false));
        }

        public async Task<IActionResult> GetAllSupplierCategory()
        {
            return View(await _serviceManager.SupplierCategoryService.GetAllSupplierCategoryAsync(false));
        }
    }
}
