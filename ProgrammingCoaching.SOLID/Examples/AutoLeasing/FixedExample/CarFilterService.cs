using ProgrammingCoaching.SOLID.Examples.AutoLeasing.Data.DummyData;
using ProgrammingCoaching.SOLID.Examples.AutoLeasing.Data.Models;

namespace ProgrammingCoaching.SOLID.Examples.AutoLeasing.FixedExample
{
  public class CarFilterService {
    private readonly List<CarModel> _cars = new MockedModels().Cars;

    public List<CarModel> FilterCars(CarFilterOptions options) {
        var filteredCars = _cars;

         if(options.MinNumberOfDoors > 0)
         {
           // filter by minNumberOfDoors
           filteredCars = filteredCars.Where(x => x.NumberOfDoors >= options.MinNumberOfDoors).ToList();
         }
         
         if(options.MinNumberOfSeats > 0)
         {
           // filter by miNumberOfSeats
           filteredCars = filteredCars.Where(x => x.NumberOfSeats >= options.MinNumberOfSeats).ToList();
         }
         
         if(options.Year > 0)
         {
           // filter by year
           filteredCars = filteredCars.Where(x => x.Year >= options.Year).ToList();
         }
         
         // max price
         if(options.MaxPrice > 0)
         {
           // filter by maxPrice
           filteredCars = filteredCars.Where(x => x.Price <= options.MaxPrice).ToList();
         }

         if (options.CarType != null) {
           // filter by carType
           filteredCars = filteredCars.Where(x => x.CarType == options.CarType).ToList();
         }
         
         if(options.CarTrack != null)
         {
           // filter by carTrack
           filteredCars = filteredCars.Where(x => x.CarTrack == options.CarTrack).ToList();
         }
         
        return filteredCars;
    }
  }
}