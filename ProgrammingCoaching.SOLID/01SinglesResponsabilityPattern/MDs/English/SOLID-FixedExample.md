# AutoLeasingManagementFixed Class

The `AutoLeasingManagementFixed` class is part of a program related to auto leasing management and represents a refactored and improved version of the previous "bad" example. This class adheres to the Single Responsibility Principle (SRP) from the SOLID principles by separating responsibilities into different services.

## Dependencies

This class depends on the following services and classes:

- `UserManager`: A service responsible for managing user information.
- `CarFilterService`: A service responsible for filtering cars based on various criteria.
- `DiscountService`: A service responsible for applying discounts to car prices.
- `CarFilterOptions`: An object representing filtering options for cars.

## Constructor

The class has a constructor that initializes instances of the `UserManager`, `CarFilterService`, and `DiscountService` services. This constructor sets up the dependencies required for the class's operations.

## Method: GetAvailableCarsOnRequest

This method retrieves a list of available cars based on the provided filtering options and the possibility of applying a discount. It follows the following steps:

1. It uses the `CarFilterService` to filter cars based on the provided filtering options.
2. If the `TryDiscount` option is enabled, it checks for the existence of the user using the `UserManager`.
3. If the user is found, it applies a discount to car prices using the `DiscountService` and returns the discounted list of cars; otherwise, it returns the unaltered list of cars.

## Method: GetAvailableCarsOnRequestWithResponseModel

This method is similar to the previous one but returns a `ResponseModel` object containing the list of cars and an error message (if any). This is a more structured way of handling responses.

## CarFilterService

The `CarFilterService` class is responsible for filtering cars based on the provided `CarFilterOptions`. It takes the responsibility of filtering cars away from the main class.

## DiscountService

The `DiscountService` class is responsible for applying discounts to car prices. It includes methods for applying discounts and returning structured `ResponseModel` objects with error messages if needed. This class encapsulates the discount logic.

## UserManager

The `UserManager` class is responsible for managing user information and retrieving users by their login name. It isolates user-related logic from the main class, ensuring better separation of concerns.

## Considerations

By separating responsibilities into distinct services, the `AutoLeasingManagementFixed` class adheres to SRP, making the code more maintainable, testable, and modular. This refactoring enhances code quality and follows best practices in software design.



# CarFilterService Class

The `CarFilterService` class is responsible for filtering cars based on the provided `CarFilterOptions`. It encapsulates the logic for narrowing down the list of cars based on various criteria.

## Properties

- `_cars`: A private field that stores a list of `CarModel` objects representing mock car data.

## Constructor

The class initializes `_cars` by accessing mock data from the `MockedModels` class, providing a source of car data for filtering operations.

## Method: FilterCars

The `FilterCars` method takes a `CarFilterOptions` object as a parameter and filters the list of cars based on the specified criteria. It performs the following actions:

- Filters cars based on the minimum number of doors (`MinNumberOfDoors`).
- Filters cars based on the minimum number of seats (`MinNumberOfSeats`).
- Filters cars based on the minimum year (`Year`).
- Filters cars based on the maximum price (`MaxPrice`).
- Filters cars based on the car type (`CarType`).
- Filters cars based on the car track (`CarTrack`).

The method returns a filtered list of cars based on the provided criteria.

# DiscountService Class

The `DiscountService` class is responsible for applying discounts to car prices. It encapsulates the discount logic and provides methods for applying discounts.

## Method: ApplyDiscount

The `ApplyDiscount` method takes two parameters: `currentPrice` (the current price of the car) and `discountPercentage` (the percentage by which the price should be discounted). It performs the following actions:

- Checks that `discountPercentage` is non-negative and `currentPrice` is greater than 0.
- Calculates the discounted price by applying the discount percentage to the current price.
- Returns the discounted price as a double value.

## Method: ApplyDiscountWithResponseModel

The `ApplyDiscountWithResponseModel` method is similar to `ApplyDiscount` but returns a structured `ResponseModel` object. It performs the following actions:

- Checks that `discountPercentage` is non-negative and `currentPrice` is greater than 0.
- Calculates the discounted price by applying the discount percentage to the current price.
- Returns a `ResponseModel<double>` object containing the discounted price if successful or an error message if any of the checks fail.

# UserManager Class

The `UserManager` class is responsible for managing user information and retrieving users by their login name. It isolates user-related logic from the main class, ensuring better separation of concerns.

## Properties

- `_users`: A private field that stores a list of `UserModel` objects representing mock user data.

## Constructor

The class initializes `_users` by accessing mock data from the `MockedModels` class, providing a source of user data for user-related operations.

## Method: GetUser

The `GetUser` method takes a `userLogin` parameter (the login name of the user to retrieve) and returns the corresponding `UserModel` object if found in the `_users` list; otherwise, it returns `null`.
