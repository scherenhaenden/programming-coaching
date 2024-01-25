# Dependency Inversion Principle (DIP) Example

This document illustrates the application of the Dependency Inversion Principle (DIP) in managing tasks with different versions of `TaskEngineType`. DIP is one of the five SOLID principles of object-oriented design and programming. It emphasizes the decoupling of high-level and low-level modules through abstractions.

## Bad Examples

Initially, different versions of `TaskManager` are tightly coupled with specific versions of `TaskEngineType`. This leads to code duplication and increases maintenance complexity.

### TaskManagerBadExample1

- **Purpose**: Manages tasks using `TaskEngineTypeV1`.
- **Method**: `RunTask(TaskEngineTypeV1 taskEngineTypeV1)`
    - Runs the task by calling `taskEngineTypeV1.Run()`, which prints "TaskEngineType1 is running".

### TaskManagerBadExample2

- **Purpose**: Manages tasks using `TaskEngineTypeV2`.
- **Method**: `RunTask(TaskEngineTypeV2 taskEngineTypeV2)`
    - Runs the task by calling `taskEngineTypeV2.Run()`, which prints "TaskEngineTypeV2 is running".

### TaskManagerBadExample3

- **Purpose**: Manages tasks using `TaskEngineTypeV3`.
- **Method**: `RunTask(TaskEngineTypeV3 taskEngineTypeV3)`
    - Runs the task by calling `taskEngineTypeV3.Run()`, which prints "TaskEngineTypev3 is running".

## Fixed Example with Dependency Inversion Principle

The fixed example demonstrates the implementation of the DIP. It introduces an interface `ITaskEngineType` and makes `TaskManagerFixedExample` depend on this abstraction rather than concrete implementations of the task engine.

### ITaskEngineType (Interface)

- **Purpose**: Defines a contract for task engines with a method `Run`.

### TaskEngineTypeV1, TaskEngineTypeV2, TaskEngineTypeV3 (Implementations of ITaskEngineType)

- **Purpose**: Implements the `ITaskEngineType` interface.
- **Method**: `Run()`
    - Each class has its own version of `Run` method, which prints the respective version of the task engine running.

### TaskManagerFixedExample

- **Purpose**: Manages tasks using any implementation of `ITaskEngineType`.
- **Method**: `RunTask(ITaskEngineType taskEngineType)`
    - Runs the task by calling `taskEngineType.Run()`. This design allows the `TaskManagerFixedExample` to work with any version of `TaskEngineType` without requiring changes to its code.

## Conclusion

By applying the Dependency Inversion Principle, the `TaskManagerFixedExample` is made independent of the concrete `TaskEngineType` versions. It depends on the `ITaskEngineType` interface, promoting a more flexible and maintainable design. This approach allows easy addition of new task engine versions without affecting the task manager, showcasing the power of dependency inversion in software design.
