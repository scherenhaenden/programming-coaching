using ProgrammingCoaching.SOLID.Examples.AutoLeasing.Data.DummyData;
using ProgrammingCoaching.SOLID.Examples.AutoLeasing.Data.Models;

namespace ProgrammingCoaching.SOLID.Examples.AutoLeasing.BadExample
{
    public class AutoLeasingManagementBad
    {
        public List<CarModel> GetAvailableCarsOnRequest(string userLogin,
            CarType? carType,
            CarTrack? carTrack,
            bool tryDiscount = false,
            int minNumberOfDoors = 0, 
            int miNumberOfSeats = 0, 
            int year = 0, 
            int maxPrice = 0)
        {
        
            List<UserModel> users = new MockedModels().Users;
            var cars = new MockedModels().Cars;
        
            // Remember to use SingleOrDefault instead of FirstOrDefault
            var user = users.SingleOrDefault(x => x.Name == userLogin);
            var discountPercentage = 10;
        
            if (user == null && tryDiscount)
            {
                throw new Exception("User not found");
            }
        
            if(minNumberOfDoors > 0)
            {
                // filter by minNumberOfDoors
                cars = cars.Where(x => x.NumberOfDoors >= minNumberOfDoors).ToList();
            }
        
            if(miNumberOfSeats > 0)
            {
                // filter by miNumberOfSeats
                cars = cars.Where(x => x.NumberOfSeats >= miNumberOfSeats).ToList();
            }
        
            if(year > 0)
            {
                // filter by year
                cars = cars.Where(x => x.Year >= year).ToList();
            }
        
            if(maxPrice > 0)
            {
                // filter by maxPrice
                cars = cars.Where(x => x.Price <= maxPrice).ToList();
            }
        
            if(carType != null)
            {
                // filter by carType
                cars = cars.Where(x => x.CarType == carType).ToList();
            }
        
            if(carTrack != null)
            {
                // filter by carTrack
                cars = cars.Where(x => x.CarTrack == carTrack).ToList();
            }
            if(user is not null && tryDiscount)
            { 
                cars = cars.Select(x => { x.Price = (x.Price *   ((100.0-discountPercentage)/100.0)); return x; }).ToList();
            }

            return cars;
        }
    }
}