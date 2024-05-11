using application.Contracts;
using domain.RequestFeatures;
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

        public async Task<IActionResult> GetAllProductCategory([FromQuery] RequestParameters requestParameters)
        {
            return View(await _serviceManager.ProductCategoryService.GetAllProductCategoriesAsync(requestParameters, false));
        }

		public async Task<IActionResult> GetProductCategoryById([FromRoute] int id)
		{
			return View(await _serviceManager.ProductCategoryService.GetProductCategoryByIdAsync(id, false));
		}

		public async Task<IActionResult> GetAllSupplierCategory([FromQuery] RequestParameters requestParameters)
        {
            return View(await _serviceManager.SupplierCategoryService.GetAllSupplierCategoriesAsync(requestParameters, false));
        }
    }
}
