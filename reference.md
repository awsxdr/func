[Home](/func/) > Reference

# Func Reference

* [`Result`](#result)
    * [`.Succeed`](#succeed-1) (static)
    * [`.Fail`](#result-fail) (static)
    * [`.CaptureResult`](#result-captureresult) (static)
    * [`.Then`](#result-then)
* [`Result<>`](#result-generic)
    * [`.Then`](#result-generic-then)
    * [`.ValueOr`](#result-generic-valueor)
* [`ResultHelper`](#resulthelper)
    * [`.Succeed`](#resulthelper-succeed) (static)
    * [`.Fail`](#resulthelper-fail) (static)
    * [`.CaptureResult`](#resulthelper-captureresult) (static)
* [`ResultHelper<>`](#resulthelper-generic)
    * [`.Fail`](#resulthelper-fail) (static)

## Result

```csharp
public interface Result { ... }
```

**Methods**

### Succeed

```csharp
public static Result Succeed()
```

Creates a new `Result` object in a successful state. The result is untyped and contains no value.

```csharp
public static Result<TValue> Succeed<TValue>(TValue value)
```

Creates a new `Result` object in a successful state. The result contains the value given by `value`.

### Fail

```csharp
public static Result Fail<TError>(TError error) where TError : ResultError
```

Creates a new `Result` object in a failed state. The result is untyped and contains the given error.

```csharp
public static Result Fail<TError>() where TError : ResultError, new()
```

Creates a new `Result` object in a failed state. The result is untyped and contains a new error of the given type constructed using the parameterless constructor.

### CaptureResult

```csharp
public static Result CaptureResult<TError>(Action func, Func<Exception, TError> catchFunc) where TError : ResultError
```

Creates a new `Result` object based on the result of a function. 

If the function throws an exception then a `Result` object in a failed state is returned. This `Result` is untyped and contains the error returned by `catchFunc`.

If the function does not throw an error then a `Result` object in a successful state. This `Result` is untyped and contains no value.

```csharp
public static async Task<Result> CaptureResult<TError>(Func<Task> func, Func<Exception, TError> catchFunc) where TError : ResultError
```