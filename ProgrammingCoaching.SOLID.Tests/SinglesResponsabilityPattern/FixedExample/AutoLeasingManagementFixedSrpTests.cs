using ProgrammingCoaching.SOLID.Data.DummyData;
using ProgrammingCoaching.SOLID.Data.Models;
using ProgrammingCoaching.SOLID.SinglesResponsabilityPattern.FixedExample;

namespace ProgrammingCoaching.SOLID.Tests.SinglesResponsabilityPattern.FixedExample;

using NUnit.Framework;
using System;
using System.Collections.Generic;

[TestFixture]
public class AutoLeasingManagementFixedSrpTests {
    private readonly AutoLeasingManagementFixedSRP _autoLeasingManagement = new();
    private readonly MockedModels _mockedData = new();
    private readonly double _possibleDiscount = 10;


    [SetUp]
    public void SetUp() {
        // Initialize the AutoLeasingManagementFixed instance
      
    }

    [Test]
    public void GetAvailableCarsOnRequest_NoDiscount_ReturnsAvailableCars() {
        // Arrange
        var userLogin = "User1";
        var options = new CarFilterOptions { TryDiscount = false };

        // Act
        var result = _autoLeasingManagement.GetAvailableCarsOnRequest(userLogin, options, _possibleDiscount);

        // Assert
        Assert.IsNotNull(result);
        Assert.IsInstanceOf<List<CarModel>>(result);
        Assert.IsTrue(result.Count > 0);
    }

    [Test]
    public void GetAvailableCarsOnRequest_WithDiscount_ReturnsDiscountedCars() {
        // Arrange
        var userLogin = "User2";
        var options = new CarFilterOptions { TryDiscount = true };

        // Act
        var result = _autoLeasingManagement.GetAvailableCarsOnRequest(userLogin, options, _possibleDiscount);

        // Assert
        Assert.IsNotNull(result);
        Assert.IsInstanceOf<List<CarModel>>(result);
        Assert.IsTrue(result.Count > 0);
        _mockedData.Cars.Take(40).ToList().ForEach(x => Assert.IsTrue( result.Single(y =>y.Id == x.Id).Price <= x.Price)); // Assuming a 10% discount is applied
        //_mockedData.Cars.ForEach(x => Assert.IsTrue(x.Price < 1000)); // Assuming a 10% discount is applied
        //Assert.IsTrue(result.TrueForAll(x => x.Price < 1000)); // Assuming a 10% discount is applied
    }

    [Test]
    public void GetAvailableCarsOnRequest_UserNotFound_ThrowsException() {
        // Arrange
        var userLogin = "NonExistentUser";
        var options = new CarFilterOptions { TryDiscount = true };

        // Act and Assert
        Assert.Throws<Exception>(() => _autoLeasingManagement.GetAvailableCarsOnRequest(userLogin, options, _possibleDiscount));
    }

    [Test]
    public void GetAvailableCarsOnRequestWithResponseModel_NoDiscount_ReturnsAvailableCarsResponseModel() {
        // Arrange
        var userLogin = "User3";
        var options = new CarFilterOptions { TryDiscount = false };

        // Act
        var result = _autoLeasingManagement.GetAvailableCarsOnRequestWithResponseModel(userLogin, options, _possibleDiscount);

        // Assert
        Assert.IsNotNull(result);
        Assert.IsNotNull(result.Data);
        Assert.IsTrue(result.Success);
        Assert.IsInstanceOf<List<CarModel>>(result.Data);
        Assert.IsTrue(result.Data?.Count > 0);
    }

    [Test]
    public void GetAvailableCarsOnRequestWithResponseModel_WithDiscount_ReturnsDiscountedCarsResponseModel() {
        // Arrange
        var userLogin = "User4";
        var options = new CarFilterOptions { TryDiscount = true };

        // Act
        var result = _autoLeasingManagement.GetAvailableCarsOnRequestWithResponseModel(userLogin, options, _possibleDiscount);

        // Assert
        Assert.IsNotNull(result);
        Assert.IsNotNull(result.Data);
        Assert.IsTrue(result.Success);
        Assert.IsInstanceOf<List<CarModel>>(result.Data);
        Assert.IsTrue(result.Data?.Count > 0);
        _mockedData.Cars.Take(40).ToList().ForEach(x => Assert.IsTrue( result.Data?.Single(y =>y.Id == x.Id).Price <= x.Price)); 
    }

    [Test]
    public void GetAvailableCarsOnRequestWithResponseModel_UserNotFound_ReturnsErrorResponseModel() {
        // Arrange
        var userLogin = "NonExistentUser";
        var options = new CarFilterOptions { TryDiscount = true };

        // Act
        var result = _autoLeasingManagement.GetAvailableCarsOnRequestWithResponseModel(userLogin, options, _possibleDiscount);

        // Assert
        Assert.IsNotNull(result);
        Assert.IsTrue(result.Success);
        Assert.IsNotNull(result.Data);
        Assert.AreEqual("User not found", result.Message);
    }
}
