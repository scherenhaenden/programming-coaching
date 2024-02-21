### User Specification

#### Class: BlacklistedService

**Description**: The `BlacklistedService` class provides functionality for checking whether a user is blacklisted based on extended user information.

**Use Case**: This class is used to determine if a user should be granted access or specific privileges based on their blacklist status. It is utilized in various parts of the application to make access control decisions.

**User Story**:
- As a system administrator, I want to use the `BlacklistedService` class to check if a user is blacklisted before granting them access to certain features of the application.

**Acceptance Criteria**:
- The `BlacklistedService` class must implement the `IBlacklistedService` interface.
- It must provide a method named `GetBlackListStatus` that takes an `ExtendedUserInformation` object as input and returns a boolean indicating whether the user is blacklisted.
- The method should return `true` if the user is blacklisted and `false` if not.
- The class should handle cases where the provided `ExtendedUserInformation` object or its properties are `null`.
- The class should return `true` if any of the following conditions are met:
    - The `IsBlackListed` property of the `RegisteredUser` property of the `ExtendedUserInformation` object is `true`.
    - The `IsBlackListed` property of the `CreditRatingUserExternals` property of the `ExtendedUserInformation` object is `true`.

---