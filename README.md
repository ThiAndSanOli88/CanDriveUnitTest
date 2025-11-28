***CanDriveUnitTest Project***

Overview
This repository contains a simple C# project designed to demonstrate unit testing practices using the MSTest framework. 
The project focuses on validating the logic of a CanDrive method, which determines whether a person of a given age is legally eligible to drive.

The project highlights:
- Input validation with exception handling.
- Boundary testing for invalid and valid age ranges.
- Automated unit testing using MSTest attributes.

The CanDrive Method
The CanDrive method encapsulates the driving eligibility logic:
public bool CanDrive(int age)
{
    if (age <= 0 || age > 120)
    {
        throw new ArgumentOutOfRangeException(nameof(age), "Age must be between 1 and 120.");
    }
    const int drivingAge = 16;
    return age >= drivingAge;
}

Key Points
- Validation: Ensures that age values are within the range of 1–120.
- Exception Handling: Throws ArgumentOutOfRangeException for invalid inputs.
- Driving Age Rule: Returns true if age is 16 or older, otherwise false.
This modification ensures that the method is robust against invalid inputs and enforces realistic constraints.

Unit Testing
Unit tests are implemented using the MSTest framework. The test class validates both normal and exceptional cases.
Example Test Cases
- Invalid Inputs: Negative values, zero, and values greater than 120 trigger exceptions.
- Boundary Conditions:
- Age = 15 → false
- Age = 16 → true
- Age = 120 → true
- Extreme Values: int.MinValue and int.MaxValue throw exceptions.
Sample Test
[TestMethod]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void TestMethod3()
{
    CanDrive(-1);
}

This test confirms that the method correctly rejects negative ages by throwing an exception.

Project Structure
CanDriveUnitTest/
 └── UnitTest1.cs   # MSTest unit tests for the CanDrive method

Getting Started
Prerequisites
- .NET 6.0 SDK or later
- Visual Studio or Visual Studio Code
- MSTest framework (included via NuGet)

Build
dotnet build

Run Tests
dotnet test

Learning Outcomes
This project demonstrates:
- Writing robust methods with input validation and exception handling.
- Applying QA methodologies through systematic unit testing.
- Using MSTest attributes ([TestClass], [TestMethod], [ExpectedException]) to automate test execution.
- Designing tests that cover boundary values, valid ranges, and invalid inputs.

License
This project was developed for educational purposes as part of the CSD268 QA Methodologies course.
It may be freely used, forked, or extended for learning and experimentation.
