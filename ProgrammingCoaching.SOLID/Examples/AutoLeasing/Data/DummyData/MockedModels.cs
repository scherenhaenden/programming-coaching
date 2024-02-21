using ProgrammingCoaching.SOLID.Examples.AutoLeasing.Data.Models;

namespace ProgrammingCoaching.SOLID.Examples.AutoLeasing.Data.DummyData
{
    public class MockedModels
    {
        public List<UserModel> Users { get; set; } = new List<UserModel>();
    
        public List<CarModel> Cars { get; set; } = new List<CarModel>();
    
        public MockedModels()
        {
            Users.Add(new UserModel {Id = 1, Name = "User1", Password = "Password1"});
            Users.Add(new UserModel {Id = 2, Name = "User2", Password = "Password2"});
            Users.Add(new UserModel {Id = 3, Name = "User3", Password = "Password3"});
            Users.Add(new UserModel {Id = 4, Name = "User4", Password = "Password4"});
            Users.Add(new UserModel {Id = 5, Name = "User5", Password = "Password5"});
        
            Cars.Add(new CarModel
            {
                Id = 1,
                Name = "Car1",
                Brand = "Brand1",
                Model = "Model1",
                Year = 2021,
                Price = 20000,
                NumberOfDoors = 2,
                NumberOfSeats = 5,
                CarType = CarType.Hatchback,
                CarTrack = CarTrack.FrontWheelDrive
            });
            Cars.Add(new CarModel
            {
                Id = 2,
                Name = "Car2",
                Brand = "Brand2",
                Model = "Model2",
                Year = 2021,
                Price = 18000,
                NumberOfDoors = 2,
                NumberOfSeats = 5,
                CarType = CarType.Hatchback,
                CarTrack = CarTrack.RearWheelDrive
            });
        
            Cars.Add(new CarModel
            {
                Id = 3,
                Name = "Car3",
                Brand = "Brand3",
                Model = "Model3",
                Year = 2021,
                Price = 25000,
                NumberOfDoors = 4,
                NumberOfSeats = 5,
                CarType = CarType.Sedan,
                CarTrack = CarTrack.AllWheelDrive
            });
        
            Cars.Add(new CarModel
            {
                Id = 4,
                Name = "Car4",
                Brand = "Brand4",
                Model = "Model4",
                Year = 2021,
                Price = 35000,
                NumberOfDoors = 4,
                NumberOfSeats = 5,
                CarType = CarType.Suv,
                CarTrack = CarTrack.AllWheelDrive
            });
        
            Cars.Add(new CarModel
            {
                Id = 5,
                Name = "Car5",
                Brand = "Brand5",
                Model = "Model5",
                Year = 2021,
                Price = 30000,
                NumberOfDoors = 4,
                NumberOfSeats = 7,
                CarType = CarType.Minivan,
                CarTrack = CarTrack.AllWheelDrive
            
            });
        
            Cars.Add(new CarModel
            {
                Id = 6,
                Name = "Car6",
                Brand = "Brand6",
                Model = "Model6",
                Year = 2021,
                Price = 40000,
                NumberOfDoors = 4,
                NumberOfSeats = 5,
                CarType = CarType.Pickup,
                CarTrack = CarTrack.AllWheelDrive
            });
        }
    }
}