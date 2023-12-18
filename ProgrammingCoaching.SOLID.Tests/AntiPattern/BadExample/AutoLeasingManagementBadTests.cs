using ProgrammingCoaching.SOLID.Data.DummyData;
using ProgrammingCoaching.SOLID.Examples.AutoLeasing.BadExample;

namespace ProgrammingCoaching.SOLID.Tests.AntiPattern.BadExample
{
    [TestFixture]
    public class AutoLeasingManagementBadTests
    {
        private readonly AutoLeasingManagementBad _autoLeasingManagement = new();
        private readonly MockedModels _mockedData = new();

        [SetUp]
        public void Setup()
        {
            //mockedData = new MockedModels();
            //autoLeasingManagement = new AutoLeasingManagementBad();
        }

        [Test]
        public void GetAvailableCarsOnRequest_WithValidUser_ReturnsCars()
        {
            var result = _autoLeasingManagement.GetAvailableCarsOnRequest("User1", null, null);
 
            Assert.IsNotEmpty(result);
            Assert.IsNotEmpty(result);
        }
        
        [Test]
        public void GetAvailableCarsOnRequest_WithValidUser_AndInvalidUserToComparePrices_ReturnsCars()
        {
            var cheaperList = _autoLeasingManagement.GetAvailableCarsOnRequest("User1", null, null,true);
            var normalPricesList = _autoLeasingManagement.GetAvailableCarsOnRequest("NonExistentUser", null, null);
            Assert.IsNotEmpty(cheaperList);
            Assert.IsNotEmpty(normalPricesList);
            
            // compare prices 
            // each car should be cheaper for the user that is not registered
            for (int i = 0; i < cheaperList.Count; i++)
            {
                Assert.Less(cheaperList[i].Price, normalPricesList[i].Price );
            }
            
            
        }

        [Test]
        public void GetAvailableCarsOnRequest_UserNotFound_ThrowsException()
        {
            Assert.Throws<Exception>(() => _autoLeasingManagement.GetAvailableCarsOnRequest("NonExistentUser", null, null, true));
        }

        [Test]
        public void GetAvailableCarsOnRequest_ApplyDiscountToExistingUser_DiscountsPrices()
        {
            var carsBeforeDiscount = _mockedData.Cars.Select(c => c.Price).ToList();
            var result = _autoLeasingManagement.GetAvailableCarsOnRequest("User1", null, null, true);
            var carsAfterDiscount = result.Select(c => c.Price).ToList();

            for (int i = 0; i < carsBeforeDiscount.Count; i++)
            {
                Assert.Less(carsAfterDiscount[i], carsBeforeDiscount[i]);
            }
        }

        [Test]
        public void GetAvailableCarsOnRequest_FilterByMinNumberOfDoors_ReturnsFilteredCars()
        {
            var minDoors = 4;
            var result = _autoLeasingManagement.GetAvailableCarsOnRequest("User1", null, null, false, minDoors);
            Assert.IsTrue(result.All(c => c.NumberOfDoors >= minDoors));
        }

        // Additional tests can be written for other filters like NumberOfSeats, Year, MaxPrice, etc.
    }
}
