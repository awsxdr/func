[Home](/func/) > Reference

# Func Reference

* [`Result`](#result)
    * [`.CaptureResult`](#captureresult)
    * [`.Fail`](#fail)
    * [`.Succeed`](#succeed)
    * [`.Then`](#then)
* [`Result<>`](#resulttvalue)
    * [`.Fail`](#fail-1)
    * [`.Then`](#then-1)
    * [`.ValueOr`](#valueor)
* [`ResultHelper`](#resulthelper)
    * [`.CaptureResult`](#captureresult-1)
    * [`.Fail`](#fail-2)
    * [`.Succeed`](#succeed-1)
* [`ResultHelper<>`](#resulthelpertvalue)
    * [`.Fail`](#fail-3)

## Result

```csharp
public interface Result { ... }
```

**Methods**

### CaptureResult

---

**Note**: This method is only available when using .NET Standard 2.1 or higher. For other .NET versions, see [ResultHelper.CaptureResult](#captureresult-1).

---

```csharp
public static Result CaptureResult<TError>(Action func, Func<Exception, TError> catchFunc) where TError : ResultError
```

Creates a new `Result` object based on the result of `func`. 

If the function throws an exception then a `Result` object in a failed state is returned. This `Result` is untyped and contains the error returned by `catchFunc`.

If the function does not throw an error then a `Result` object in a successful state. This `Result` is untyped and contains no value.

```csharp
public static async Task<Result> CaptureResult<TError>(Func<Task> func, Func<Exception, TError> catchFunc) where TError : ResultError
```

Creates a new `Result` object based on the result of `func`. 

If the function throws an exception then a `Result` object in a failed state is returned. This `Result` is untyped and contains the error returned by `catchFunc`.

If the function does not throw an error then a `Result` object in a successful state. This `Result` is untyped and contains no value.

```csharp
public static Result<TValue> CaptureResult<TValue, TError>(Func<TValue> func, Func<Exception, TError> catchFunc) where TError : ResultError
```

Creates a new `Result` object based on the result of `func`. 

If the function throws an exception then a `Result` object in a failed state is returned. This `Result` is typed to the return type of `func` and contains the error returned by `catchFunc`.

If the function does not throw an error then a `Result` object in a successful state. This `Result` contains the value returned by `func`.

```csharp
public static async Task<Result<TValue>> CaptureResult<TValue, TError>(Func<Task<TValue>> func, Func<Exception, TError> catchFunc) where TError : ResultError
```

### Fail

---

**Note**: This method is only available when using .NET Standard 2.1 or higher. For other .NET versions, see [ResultHelper.Fail](#fail-2).

---

```csharp
public static Result Fail<TError>(TError error) where TError : ResultError
```

Creates a new `Result` object in a failed state. The result is untyped and contains the given error.

```csharp
public static Result Fail<TError>() where TError : ResultError, new()
```

Creates a new `Result` object in a failed state. The result is untyped and contains a new error of the given type constructed using the parameterless constructor.

### Succeed

---

**Note**: This method is only available when using .NET Standard 2.1 or higher. For other .NET versions, see [ResultHelper.Succeed](#succeed-1).

---

```csharp
public static Result Succeed()
```

Creates a new `Result` object in a successful state. The result is untyped and contains no value.

```csharp
public static Result<TValue> Succeed<TValue>(TValue value)
```

Creates a new `Result` object in a successful state. The result contains the value given by `value`.

### Then

```csharp
public Result Then(Func<Result> resultFunc)
```

If the `Result` is in a success state then `resultFunc` is invoked and the result of that is returned. Otherwise, a failed `Result` containing the current error is returned.

```csharp
public Task<Result> Then(Func<Task<Result>> resultFunc)
```

If the `Result` is in a success state then `resultFunc` is invoked and the result of that is returned. Otherwise, a completed `Task` containing a failed `Result` with the current error is returned.

```csharp
public Result<TResultValue> Then<TResultValue>(Func<Result<TResultValue>> resultFunc)
```

If the `Result` is in a success state then `resultFunc` is invoked and the result of that is returned. Otherwise, a failed `Result<TResultValue>` containing the current error is returned.

```csharp
public Task<Result<TResultValue>> Then<TResultValue>(Func<Task<Result<TResultValue>>> resultFunc)
```

If the `Result` is in a success state then `resultFunc` is invoked and the result of that is returned. Otherwise, a completed `Task` containing a failed `Result<TResultValue>` containing the current error is returned.

## Result\<TValue\>

```csharp
public interface Result<TValue> : Result
```

**Methods**

### Fail

---

**Note**: This method is only available when using .NET Standard 2.1 or higher. For other .NET versions, see [ResultHelper<>.Fail](#fail-3).

---

```csharp
public static Result<TValue> Fail<TError>(TError error) where TError : ResultError
```

Creates a new `Result` object in a failed state. The result is typed to `TValue` and contains the given error.

```csharp
public static Result<TValue> Fail<TError>() where TError : ResultError, new()
```

Creates a new `Result` object in a failed state. The result is typed to `TValue` and contains a new error of the given type constructed using the parameterless constructor.

### Then

```csharp
public Task<Result> Then(Func<TValue, Task<Result>> resultFunc)
```

If the `Result` is in a success state then `resultFunc` is invoked with the current value and the result of that is returned. Otherwise, a completed `Task` containing a failed `Result` containing the current error is returned.

```csharp
public Result Then(Func<TValue, Result> resultFunc)
```

If the `Result` is in a success state then `resultFunc` is invoked with the current value and the result of that is returned. Otherwise, a failed `Result` containing the current error is returned.

```csharp
public Task<Result<TResultValue>> Then<TResultValue>(Func<TValue, Task<Result<TResultValue>>> resultFunc)
```

If the `Result` is in a success state then `resultFunc` is invoked with the current value and the result of that is returned. Otherwise, a completed `Task` containing a failed `Result<TResultValue>` containing the current error is returned.

```csharp
public Result<TResultValue> Then<TResultValue>(Func<TValue, Result<TResultValue>> resultFunc)
```

If the `Result` is in a success state then `resultFunc` is invoked with the current value and the result of that is returned. Otherwise, a failed `Result<TResultValue>` containing the current error is returned.

### ValueOr

```csharp
public TValue ValueOr(Func<TValue> onError)
```

If the `Result` is in a success state then the current value is returned. Otherwise, `onError` is invoked and the return value of that is returned.

```csharp
public Task<TValue> ValueOr(Func<Task<TValue>> onError)
```

If the `Result` is in a success state then a completed `Task` containing the current value is returned. Otherwise, `onError` is invoked and the return value of that is returned.

## ResultHelper

---

**Note**: This type is only available when using .NET Standard 2.0 or lower or .NET Framework. For .NET standard 2.1 or above, see [Result](#result).

---

**Methods**

### CaptureResult

```csharp
public static Result CaptureResult<TError>(Action func, Func<Exception, TError> catchFunc) where TError : ResultError
```

Creates a new `Result` object based on the result of `func`. 

If the function throws an exception then a `Result` object in a failed state is returned. This `Result` is untyped and contains the error returned by `catchFunc`.

If the function does not throw an error then a `Result` object in a successful state. This `Result` is untyped and contains no value.

```csharp
public static async Task<Result> CaptureResult<TError>(Func<Task> func, Func<Exception, TError> catchFunc) where TError : ResultError
```

Creates a new `Result` object based on the result of `func`. 

If the function throws an exception then a `Result` object in a failed state is returned. This `Result` is untyped and contains the error returned by `catchFunc`.

If the function does not throw an error then a `Result` object in a successful state. This `Result` is untyped and contains no value.

```csharp
public static Result<TValue> CaptureResult<TValue, TError>(Func<TValue> func, Func<Exception, TError> catchFunc) where TError : ResultError
```

Creates a new `Result` object based on the result of `func`. 

If the function throws an exception then a `Result` object in a failed state is returned. This `Result` is typed to the return type of `func` and contains the error returned by `catchFunc`.

If the function does not throw an error then a `Result` object in a successful state. This `Result` contains the value returned by `func`.

```csharp
public static async Task<Result<TValue>> CaptureResult<TValue, TError>(Func<Task<TValue>> func, Func<Exception, TError> catchFunc) where TError : ResultError
```

### Fail

```csharp
public static Result Fail<TError>(TError error) where TError : ResultError
```

Creates a new `Result` object in a failed state. The result is untyped and contains the given error.

```csharp
public static Result Fail<TError>() where TError : ResultError, new()
```

Creates a new `Result` object in a failed state. The result is untyped and contains a new error of the given type constructed using the parameterless constructor.

### Succeed

```csharp
public static Result Succeed()
```

Creates a new `Result` object in a successful state. The result is untyped and contains no value.

```csharp
public static Result<TValue> Succeed<TValue>(TValue value)
```

Creates a new `Result` object in a successful state. The result contains the value given by `value`.

## ResultHelper\<TValue\>

---

**Note**: This type is only available when using .NET Standard 2.0 or lower or .NET Framework. For .NET standard 2.1 or above, see [Result](#resulttvalue).

---

**Methods**

### Fail

```csharp
public static Result<TValue> Fail<TError>(TError error) where TError : ResultError
```

Creates a new `Result` object in a failed state. The result is typed to `TValue` and contains the given error.

```csharp
public static Result<TValue> Fail<TError>() where TError : ResultError, new()
```

Creates a new `Result` object in a failed state. The result is typed to `TValue` and contains a new error of the given type constructed using the parameterless constructor.
