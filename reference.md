[Home](/func/) > Reference

# Func Reference

* [`Result`](#result)
    * [`.Succeed`](#result-succeed) (static)
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

## `Result`

```csharp
public interface Result { ... }
```

**Methods**

### `Succeed`

```csharp
public static Result Succeed()
```

Creates a new `Result` object in a successful state. The result is untyped and contains no value.

```csharp
public static Result<TValue> Succeed<TValue>(TValue value)
```

Creates a new `Result` object in a successful state. The result contains the value given by `value`.

### `Fail`

```csharp
public static Result Fail<TError>(TError error) where TError : ResultError
```