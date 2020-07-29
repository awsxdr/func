// ReSharper disable InconsistentNaming
#pragma warning disable IDE1006 // Naming Styles
namespace Func
{
    using System;
    using System.Threading.Tasks;

    public static class TaskResultExtensionMethods
    {
        public static Task<Result> Then(this Task<Result> @this, Func<Task<Result>> resultFunc) =>
            @this.ContinueWith(x => x.Result.Then(resultFunc)).Unwrap();

        public static Task<Result> Then(this Task<Result> @this, Func<Result> resultFunc) =>
            @this.ContinueWith(x => x.Result.Then(resultFunc));

        public static Task<Result> Then<TIn>(this Task<Result<TIn>> @this, Func<Task<Result>> resultFunc) =>
            @this.ContinueWith(x => x.Result.Then(resultFunc)).Unwrap();

        public static Task<Result> Then<TIn>(this Task<Result<TIn>> @this, Func<Result> resultFunc) =>
            @this.ContinueWith(x => x.Result.Then(resultFunc));

        public static Task<Result> Then<TIn>(this Task<Result<TIn>> @this, Func<TIn, Task<Result>> resultFunc) =>
            @this.ContinueWith(x => x.Result.Then(resultFunc)).Unwrap();

        public static Task<Result> Then<TIn>(this Task<Result<TIn>> @this, Func<TIn, Result> resultFunc) =>
            @this.ContinueWith(x => x.Result.Then(resultFunc));

        public static Task<Result<TOut>> Then<TOut>(this Task<Result> @this, Func<Task<Result<TOut>>> resultFunc) =>
            @this.ContinueWith(x => x.Result.Then(resultFunc)).Unwrap();

        public static Task<Result<TOut>> Then<TOut>(this Task<Result> @this, Func<Result<TOut>> resultFunc) =>
            @this.ContinueWith(x => x.Result.Then(resultFunc));

        public static Task<Result<TOut>> Then<TIn, TOut>(this Task<Result<TIn>> @this, Func<Task<Result<TOut>>> resultFunc) =>
            @this.ContinueWith(x => x.Result.Then(resultFunc)).Unwrap();

        public static Task<Result<TOut>> Then<TIn, TOut>(this Task<Result<TIn>> @this, Func<Result<TOut>> resultFunc) =>
            @this.ContinueWith(x => x.Result.Then(resultFunc));

        public static Task<Result<TOut>> Then<TIn, TOut>(this Task<Result<TIn>> @this, Func<TIn, Task<Result<TOut>>> resultFunc) =>
            @this.ContinueWith(x => x.Result.Then(resultFunc)).Unwrap();

        public static Task<Result<TOut>> Then<TIn, TOut>(this Task<Result<TIn>> @this, Func<TIn, Result<TOut>> resultFunc) =>
            @this.ContinueWith(x => x.Result.Then(resultFunc));

        public static Task<Result> OnSuccess(this Task<Result> @this, Action func) =>
            @this.ContinueWith(x => x.Result.OnSuccess(func));

        public static Task<Result> OnSuccess(this Task<Result> @this, Func<Task> func) =>
            @this.ContinueWith(x => x.Result.OnSuccess(func)).Unwrap();

        public static Task<Result<TResultValue>> OnSuccess<TResultValue>(this Task<Result<TResultValue>> @this, Action func) =>
            @this.ContinueWith(x => x.Result.OnSuccess(func));

        public static Task<Result<TResultValue>> OnSuccess<TResultValue>(this Task<Result<TResultValue>> @this, Func<Task> func) =>
            @this.ContinueWith(x => x.Result.OnSuccess(func)).Unwrap();

        public static Task<Result<TResultValue>> OnSuccess<TResultValue>(this Task<Result<TResultValue>> @this, Action<TResultValue> func) =>
            @this.ContinueWith(x => x.Result.OnSuccess(func));

        public static Task<Result<TResultValue>> OnSuccess<TResultValue>(this Task<Result<TResultValue>> @this, Func<TResultValue, Task> func) =>
            @this.ContinueWith(x => x.Result.OnSuccess(func)).Unwrap();

        public static Task<Result> OnError(this Task<Result> @this, Action func) =>
            @this.ContinueWith(x => x.Result.OnError(func));

        public static Task<Result> OnError(this Task<Result> @this, Func<Task> func) =>
            @this.ContinueWith(x => x.Result.OnError(func)).Unwrap();

        public static Task<Result> OnError<TError>(this Task<Result> @this, Action<TError> func)
            where TError : ResultError =>
            @this.ContinueWith(x => x.Result.OnError(func));

        public static Task<Result> OnError<TError>(this Task<Result> @this, Func<TError, Task> func)
            where TError : ResultError =>
            @this.ContinueWith(x => x.Result.OnError(func)).Unwrap();

        public static Task<Result<TResultValue>> OnError<TResultValue>(this Task<Result<TResultValue>> @this, Action func) =>
            @this.ContinueWith(x => x.Result.OnError(func));

        public static Task<Result<TResultValue>> OnError<TResultValue>(this Task<Result<TResultValue>> @this, Func<Task> func) =>
            @this.ContinueWith(x => x.Result.OnError(func)).Unwrap();

        public static Task<Result<TResultValue>> OnError<TError, TResultValue>(this Task<Result<TResultValue>> @this, Action<TError> func)
            where TError : ResultError =>
            @this.ContinueWith(x => x.Result.OnError(func));

        public static Task<Result<TResultValue>> OnError<TError, TResultValue>(this Task<Result<TResultValue>> @this, Func<TError, Task> func)
            where TError : ResultError =>
            @this.ContinueWith(x => x.Result.OnError(func)).Unwrap();

        public static Task<TValue> ValueOr<TValue>(this Task<Result<TValue>> @this, Func<Task<TValue>> onError) =>
            @this.ContinueWith(x =>
                x.Result is Success<TValue> s
                ? s.Value.ToTask()
                : onError())
            .Unwrap();

        public static Task<TValue> ValueOr<TValue>(this Task<Result<TValue>> @this, Func<TValue> onError) =>
            @this.ContinueWith(x =>
                x.Result is Success<TValue> s
                ? s.Value
                : onError());
    }
}
#pragma warning restore IDE1006 // Naming Styles
