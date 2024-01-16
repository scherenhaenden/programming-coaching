

### Technical Specification

#### Class: BlacklistedService

**Description**: The `BlacklistedService` class is responsible for implementing the `IBlacklistedService` interface, providing a method to check the blacklist status of a user based on their extended user information.

**Class Members**:
- **Method**: `GetBlackListStatus`
    - **Description**: Checks if a user is blacklisted based on extended user information.
    - **Parameters**:
        - `extendedUserInformation` (Type: `ExtendedUserInformation`): The extended user information to examine.
    - **Returns**:
        - Type: `bool`
        - `true` if the user is blacklisted based on the defined conditions, `false` otherwise.
    - **Behavior**:
        - The method handles cases where the `extendedUserInformation` parameter or its properties may be `null` by using null-conditional operators (`?.`).
        - It returns `true` if any of the following conditions are met:
            - The `IsBlackListed` property of the `RegisteredUser` property of the `extendedUserInformation` object is `true`.
            - The `IsBlackListed` property of the `CreditRatingUserExternals` property of the `extendedUserInformation` object is `true`.
    - **Usage**:
        - This method is used in various parts of the application to determine if a user should be considered blacklisted or not for access control decisions.

**Interface Implementation**: The `BlacklistedService` class implements the `IBlacklistedService` interface, ensuring compatibility with other parts of the application that rely on this interface for user status checks.

**Error Handling**: The class handles potential `null` values gracefully using the null-conditional operator (`?.`) to prevent null reference exceptions.

**Usage**: The `BlacklistedService` class is designed to be used in scenarios where it's necessary to check a user's blacklist status based on extended user information, such as during access control checks or privilege management.

**Testing**: The class should be thoroughly unit-tested to verify its behavior under various conditions, including cases where the input `extendedUserInformation` object is `null` or has null properties. Mocking or providing test data for the `ExtendedUserInformation` object is advisable during testing.