using MCEightToTenEndpoints.Services;
using Microsoft.AspNetCore.Mvc;

namespace MCEightToTenEndpoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RestaurantPickerController : ControllerBase
    {
        private readonly RestaurantPickerServices _restaurantPickerServices;

        public RestaurantPickerController(RestaurantPickerServices restaurantPickerServices)
        {
            _restaurantPickerServices = restaurantPickerServices;
        }

        [HttpGet]
        [Route("FoodPicker/{pizzaMexicanFastFood}")]
        public string FoodPicker(string pizzaMexicanFastFood)
        {
            return _restaurantPickerServices.FoodPicker(pizzaMexicanFastFood);
        }
    }



}