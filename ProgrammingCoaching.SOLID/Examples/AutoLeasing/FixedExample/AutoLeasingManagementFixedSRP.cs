using ProgrammingCoaching.SOLID.Examples.AutoLeasing.Data.Models;

namespace ProgrammingCoaching.SOLID.Examples.AutoLeasing.FixedExample
{
    public class AutoLeasingManagementFixedSRP
    {
        private readonly UserManager _userManager;
        private readonly CarFilterService _carFilterService;
        private readonly DiscountService _discountService;

        public AutoLeasingManagementFixedSRP() {
        _userManager = new UserManager();
        _carFilterService = new CarFilterService();
        _discountService = new DiscountService();
    }
    
    
        public List<CarModel> GetAvailableCarsOnRequest(string userLogin, CarFilterOptions options, double possibleDiscount) {
        var cars = _carFilterService.FilterCars(options);

        if (options.TryDiscount) {
            
            var user = _userManager.GetUser(userLogin);
            if (user == null) {
                throw new Exception("User not found");
            }
            return cars.Select(x => { x.Price = _discountService.ApplyDiscount(x.Price, possibleDiscount); return x; }).ToList();
        }
        return cars;
    }
    
    
        public ResponseModel<List<CarModel>> GetAvailableCarsOnRequestWithResponseModel(string userLogin, CarFilterOptions options, double possibleDiscount) {
        var cars = _carFilterService.FilterCars(options);

        if (options.TryDiscount) {
            
            var user = _userManager.GetUser(userLogin);
            if (user == null)
            {
                return new ResponseModel<List<CarModel>>(cars, "User not found", true);
            }
            //var cars2 = cars.Select(x => x).ToList();
            
            //cars2 = cars.Select(x => { x.Price = _discountService.ApplyDiscount(x.Price, 10); return x; }).ToList();
            cars = cars.Select(x => { x.Price = _discountService.ApplyDiscount(x.Price, possibleDiscount); return x; }).ToList();
        }

        return new ResponseModel<List<CarModel>>(cars);
    }
    }
}