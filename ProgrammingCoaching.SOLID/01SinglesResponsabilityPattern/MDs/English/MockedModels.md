# MockedModels Class

The `MockedModels` class is part of a program related to auto leasing management and serves as a source of mock data for users and cars. It is responsible for creating and populating lists of `UserModel` and `CarModel` objects to simulate data storage.

## Properties

- `Users`: A list of `UserModel` objects representing mock user data.
- `Cars`: A list of `CarModel` objects representing mock car data.

## Constructor

The `MockedModels` class has a constructor that initializes the `Users` and `Cars` properties by adding mock data to these lists. Here's a breakdown of the data added:

### Users

- It creates five mock user objects with different IDs, names, and passwords.

### Cars

- It creates six mock car objects with different IDs, names, brands, models, years, prices, number of doors, number of seats, car types, and car tracks.

## Purpose

The `MockedModels` class is used for testing and development purposes to simulate the presence of users and cars without relying on an actual database or external data source. It allows developers to work with sample data when implementing and testing various functionalities within the program.

## Usage

This class is typically used in conjunction with other classes and methods that require access to user and car data. It provides a convenient way to access mock data for testing and development.

## Example Usage

```csharp
// Creating an instance of MockedModels to access mock data
var mockedData = new MockedModels();

// Accessing mock user data
var users = mockedData.Users;
var user1 = users.FirstOrDefault(u => u.Name == "User1");

// Accessing mock car data
var cars = mockedData.Cars;
var car1 = cars.FirstOrDefault(c => c.Name == "Car1");
