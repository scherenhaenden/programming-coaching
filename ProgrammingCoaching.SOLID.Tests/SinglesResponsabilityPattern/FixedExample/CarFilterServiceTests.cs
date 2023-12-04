using ProgrammingCoaching.SOLID.SinglesResponsabilityPattern.Data.DummyData;
using ProgrammingCoaching.SOLID.SinglesResponsabilityPattern.Data.Models;
using ProgrammingCoaching.SOLID.SinglesResponsabilityPattern.FixedExample;

namespace ProgrammingCoaching.SOLID.Tests.SinglesResponsabilityPattern.FixedExample;

[TestFixture]
public class CarFilterServiceTests {
    private List<CarModel> _mockedCars;

    [SetUp]
    public void SetUp() {
        // Initialize the list of mocked cars for testing
        _mockedCars = new MockedModels().Cars;
    }

    [Test]
    public void FilterCars_FilterByMinNumberOfDoors_ReturnsFilteredCars() {
        // Arrange
        var carFilterService = new CarFilterService();
        var options = new CarFilterOptions { MinNumberOfDoors = 4 };

        // Act
        var filteredCars = carFilterService.FilterCars(options);

        // Assert
        Assert.IsTrue(filteredCars.All(x => x.NumberOfDoors >= options.MinNumberOfDoors));
    }

    [Test]
    public void FilterCars_FilterByMinNumberOfSeats_ReturnsFilteredCars() {
        // Arrange
        var carFilterService = new CarFilterService();
        var options = new CarFilterOptions { MinNumberOfSeats = 5 };

        // Act
        var filteredCars = carFilterService.FilterCars(options);

        // Assert
        Assert.IsTrue(filteredCars.All(x => x.NumberOfSeats >= options.MinNumberOfSeats));
    }

    [Test]
    public void FilterCars_FilterByYear_ReturnsFilteredCars() {
        // Arrange
        var carFilterService = new CarFilterService();
        var options = new CarFilterOptions { Year = 2020 };

        // Act
        var filteredCars = carFilterService.FilterCars(options);

        // Assert
        Assert.IsTrue(filteredCars.All(x => x.Year >= options.Year));
    }

    [Test]
    public void FilterCars_FilterByMaxPrice_ReturnsFilteredCars() {
        // Arrange
        var carFilterService = new CarFilterService();
        var options = new CarFilterOptions { MaxPrice = 30000 };

        // Act
        var filteredCars = carFilterService.FilterCars(options);

        // Assert
        Assert.IsTrue(filteredCars.All(x => x.Price <= options.MaxPrice));
    }

    [Test]
    public void FilterCars_FilterByCarType_ReturnsFilteredCars() {
        // Arrange
        var carFilterService = new CarFilterService();
        var options = new CarFilterOptions { CarType = CarType.Sedan };

        // Act
        var filteredCars = carFilterService.FilterCars(options);

        // Assert
        Assert.IsTrue(filteredCars.All(x => x.CarType == options.CarType));
    }

    [Test]
    public void FilterCars_FilterByCarTrack_ReturnsFilteredCars() {
        // Arrange
        var carFilterService = new CarFilterService();
        var options = new CarFilterOptions { CarTrack = CarTrack.AllWheelDrive };

        // Act
        var filteredCars = carFilterService.FilterCars(options);

        // Assert
        Assert.IsTrue(filteredCars.All(x => x.CarTrack == options.CarTrack));
    }
}
