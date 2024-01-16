# CarModel Class

The `CarModel` class is part of a program related to auto leasing management and represents a data model for cars. It defines various properties that describe the characteristics of a car.

## Properties

- `Id`: An integer representing the unique identifier of the car.
- `Name`: A string representing the name of the car.
- `Brand`: A string representing the brand of the car.
- `Model`: A string representing the model of the car.
- `Year`: An integer representing the manufacturing year of the car.
- `Price`: A double representing the price of the car.
- `NumberOfDoors`: An integer representing the number of doors in the car.
- `NumberOfSeats`: An integer representing the number of seats in the car.
- `CarType`: An enumeration representing the type of car (e.g., sedan, SUV, etc.).
- `CarTrack`: An enumeration representing the car track (e.g., standard, off-road, etc.).

## Purpose

The `CarModel` class serves as a data structure to store information about cars, such as their attributes and characteristics. It is used within the program to represent car objects and facilitate data manipulation.

## Usage

This class is typically used in conjunction with other classes and methods to create, retrieve, update, and display information about cars in the auto leasing management system.

## Example Usage

```csharp
// Creating a new car object
var car = new CarModel
{
    Id = 1,
    Name = "My Car",
    Brand = "BrandName",
    Model = "ModelName",
    Year = 2023,
    Price = 25000.00,
    NumberOfDoors = 4,
    NumberOfSeats = 5,
    CarType = CarType.Sedan,
    CarTrack = CarTrack.Standard
};

// Accessing car properties
Console.WriteLine($"Car Name: {car.Name}");
Console.WriteLine($"Car Brand: {car.Brand}");
// ...and so on
