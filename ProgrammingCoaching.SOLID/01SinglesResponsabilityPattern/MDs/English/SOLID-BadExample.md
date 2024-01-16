# AutoLeasingManagementBad Class

The `AutoLeasingManagementBad` class is part of a program related to auto leasing management and demonstrates a code example that violates the Single Responsibility Principle (SRP) from the SOLID principles. This code is considered a "bad" example because it combines multiple responsibilities within a single class.

## Purpose

The main purpose of this class is to retrieve a list of available cars based on various filtering criteria provided as method parameters. It also offers a discount on car prices under certain conditions.

## Dependencies

This class depends on the following namespaces and classes:

- `ProgrammingCoaching.SOLID.SinglesResponsabilityPattern.Data.DummyData`: This namespace is used to access mock data for users and cars.
- `ProgrammingCoaching.SOLID.SinglesResponsabilityPattern.Data.Models`: This namespace is used to work with data models like `CarModel` and `UserModel`.

## Method: GetAvailableCarsOnRequest

The `GetAvailableCarsOnRequest` method retrieves a list of available cars based on the following parameters:

- `userLogin`: The name of the user requesting the cars.
- `carType`: The type of car to filter by (optional).
- `carTrack`: The car track to filter by (optional).
- `tryDiscount`: A boolean flag indicating whether to apply a discount to car prices (default is `false`).
- `minNumberOfDoors`: The minimum number of doors for filtering (default is `0`).
- `miNumberOfSeats`: The minimum number of seats for filtering (default is `0`).
- `year`: The minimum year for filtering (default is `0`).
- `maxPrice`: The maximum price for filtering (default is `0`).

### Code Explanation

1. It initializes `users` and `cars` by accessing mock data.
2. It attempts to find a user with the provided `userLogin`. If the user is not found and `tryDiscount` is `true`, it throws an exception.
3. It applies various filters based on the provided parameters to narrow down the list of available cars.
4. If `tryDiscount` is `true` and a user is found, it applies a discount to car prices.
5. Finally, it returns the filtered and optionally discounted list of cars.

## Code Issues

This code violates the Single Responsibility Principle (SRP) because it combines multiple responsibilities within a single method:

- Data access (retrieving users and cars).
- Filtering cars based on various criteria.
- Applying discounts to car prices.
- Handling exceptions.

This makes the code less maintainable and harder to test. A better approach would be to split these responsibilities into separate classes or methods, adhering to SOLID principles for improved code quality.
