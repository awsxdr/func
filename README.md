# Func

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://github.com/awsxdr/Func/blob/master/LICENSE)
![Release](https://github.com/awsxdr/func/workflows/Release/badge.svg)
![CI](https://github.com/awsxdr/func/workflows/CI/badge.svg?branch=develop)

Func is a library designed to expand C#'s functional programming capabilities.

## Links

* [Getting Started](getting-started)
* Concepts
    * [Chaining](concepts-chaining)
    * [Currying](concepts-currying)
    * [Optional values](concepts-option)
    * [Ralway-oriented programming](concepts-rop)
    * [Unions](concepts-union)
* [Reference](reference)

## Contents

* [Usage](#usage)
  * [Map & Tee](#map-and-tee)
  * [Options](#options)
  * [Railway-oriented programming](#railway-oriented-programming-result)

## Usage

### Map and Tee

`Map` and `Tee` are methods used to chain method calls. They can be thought of as equivalent to `Select` and `ForEach` but operating on single items.

`Map` takes in a value, executes a given function on it and returns the result. This is similar to the behaviour of the `|>` operator in F#.

`Tee` takes in a value, executes a given method, and returns the original value.

```csharp
using Func;

public class Example
{
    private readonly ILogger _logger;

    public Example(ILogger logger) => _logger = logger;

    public string GetWelcomeMessage() =>
        GetCurrentUserId()
        .Tee(id => _logger.LogInformation("Generating welcome message for user {0}", id))
        .Map(GetUserNameFromId)
        .Map(GetWelcomeMessageForUserName);

    private int GetCurrentUserId() => 123;
    private string GetUserNameFromId(int id) => "Test User";
    private string GetWelcomeMessageForUserName(string userName) => $"Hello, {userName}";
}
```

#### Asynchronous operations

`Map` and `Tee` are designed to work happily with asynchronous functions returning `Task` objects. Methods returning tasks which are chained together will return a single unified task.

```csharp
using Func;

public class Example
{
    private readonly ILogger _logger;

    public Example(ILogger logger) => _logger = logger;

    public async Task<string> GetWelcomeMessage() =>
        await GetCurrentUserId()
        .Tee((int id) => _logger.LogInformation("Generating welcome message for user {0}", id))
        .Map(GetUserNameFromId)
        .Map(GetWelcomeMessageForUserName);

    private Task<int> GetCurrentUserId() => Task.FromResult(123);
    private Task<string> GetUserNameFromId(int id) => Task.FromResult("Test User");
    private string GetWelcomeMessageForUserName(string userName) => $"Hello, {userName}";
}
```

Here, several methods are chained together; some of them returning tasks, some not. A single `Task` is returned which performs all of the chained actions.

Of note here is the use of `int` on `Tee`. Generally the compiler will be able to infer the types being used, but in cases like this where the argument is of type `object` a type needs specifying. If you encounter these sort of errors you can provide the types or, perhaps preferably, provide a more strongly typed method to call.

#### Multiple arguments

`Map` and `Tee` support methods with up to 15 arguments. Additional arguments are provided as parameters to `Map` and `Tee` following the method. The value that `Map` or `Tee` is acting on is always passed as the last argument.

In the following example, we call `string.Join` which has the signature `string Join(string separator, IEnumerable<string> values)`. `Map` is called on the string array and the separator is passed as an argument to `Map`.

```csharp
public class Example
{
    public void OutputUserNames() =>
        GetUserNames()
        .Map(string.Join, ", ")
        .Tee(Console.WriteLine);

    private IEnumerable<string> GetUserNames() => new[] { "Anne", "Brian", "Claire", "Daniel" };
}
```

#### Currying and partial application

Full currying and partial application support is being worked on but is currently not ready.

### Options

Options represent a way of marking a value as optional. Optional items offer benefits over nullable items because they enforce checking for a value and thus remove the possibility of ending up with the dreaded `NullReferenceException`s.

```csharp
using static Func.Option;

public class Example
{
    public static string GetDescription(Option<int> value) =>
        value switch
        {
            Some<int> x when x.Value > 10 => "Huge",
            Some<int> x when x.Value > 5 => "Big",
            Some<int> x when x.Value < 1 => "Tiny",
            Some<int> x when x.Value < 5 => "Small",
            Some<int> _ => "Average",
            None _ => "Empty",
            _ => "Unexpected!"
        };

    public void Test()
    {
        _ = GetDescription(Some(11));    // "Huge"
        _ = GetDescription(Some(3));     // "Small"
        _ = GetDescription(None<int>()); // "Empty"
    }
}
```

The above example shows a function which expects either an integer or nothing. The `Value` property can only be retrieved once the `Option` has been cast to `Some`.

Also supported is passing values when the type isn't specified. In the below example, any type can be passed in.

```csharp
using static Func.Option;

public class Example
{
    public static string GetDescription(Option value) =>
        value switch
        {
            Some<int> _ => "Number",
            Some<double> _ => "Number",
            Some<string> _ => "Text",
            Some _ => "Something else",
            None _ => "Empty",
            _ => "Unexpected!"
        };

    public void Test()
    {
        GetDescription(Some(11));      // "Number"
        GetDescription(Some(8.42));    // "Number"
        GetDescription(Some("Hello")); // "Text"
        GetDescription(Some(false));   // "Something else"
        GetDescription(None());        // "Empty"
    }
}
```

### Railway-oriented programming (Result)

Func supports railway-oriented programming (ROP). Functions which return a `Result` object can be chained together with calls to `Then`. If any method in the chain fails then the chain stops executing and a fail is returned. The concept is similar to Javascript's promises or Rust's `Result` type.

The aim of ROP is to prevent the use of exceptions for program flow. Methods can fail on non-exceptional errors to avoid continuing without the overhead of throwing an exception.

```csharp
using System;
using System.Threading.Tasks;
using Func;
using static Func.Result;

public class Example
{
    private readonly ILogger _logger;

    public Example(ILogger logger) => _logger = logger;

    public async Task<string> GetWelcomeMessage(string username) =>
        await
            GetCurrentUserId(username)
            .Then(GetUserFullNameFromId)
            .Then(GetWelcomeMessageForUserFullName)
            .OnSuccess(() => _logger.LogInformation($"User {username} found"))
            .OnError((UserNotFoundError e) => { _logger.LogWarn($"User {username} not found"); })
            .OnError(() => _logger.LogWarn("Something went very wrong!"))
        switch
        {
            Success<string> s => s.Value,
            Failure<UserNotFoundError> _ => "User could not be found",
            Failure _ => throw new Exception("Unexpected error occurred getting welcome message for user")
        };

    private Task<Result<int>> GetCurrentUserId(string username) =>
        (username == "test"
            ? Succeed(123)
            : Result<int>.Fail(new UserNotFoundError())
        ).ToTask();

    private Task<Result<string>> GetUserFullNameFromId(int id) =>
        Succeed("Test User").ToTask();

    private Result<string> GetWelcomeMessageForUserFullName(string userFullName) =>
        Succeed($"Hello, {userFullName}");
}

public class UserNotFoundError : ResultError { }
```

Note here that the call to `Fail` requires the result types to be passed. This is because the types can't be inferred.

Also note that the error type is specified in the lambda for `OnError`. If not specified here then the method would require both the error type and result type specified in angular brackets.