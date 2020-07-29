// ReSharper disable InconsistentNaming
#pragma warning disable IDE1006 // Naming Styles
namespace Func
{
    using System;
    using System.Threading.Tasks;

    public interface Result
    {
        public static Result Succeed() =>
            new SuccessClass();

        public static Result<TValue> Succeed<TValue>(TValue value) =>
            new SuccessClass<TValue>(value);

        public static Result Fail<TError>(TError error) where TError : ResultError =>
            new FailureClass<object, TError>(error);

        public static Result CaptureResult<TError>(Action func, Func<Exception, TError> catchFunc) where TError : ResultError
        {
            try
            {
                func();

                return Succeed();
            }
            catch(Exception ex)
            {
                return Fail(catchFunc(ex));
            }
        }

        public static async Task<Result> CaptureResult<TError>(Func<Task> func, Func<Exception, TError> catchFunc) where TError : ResultError
        {
            try
            {
                await func();

                return Succeed();
            }
            catch(Exception ex)
            {
                return Fail(catchFunc(ex));
            }
        }

        public static Result<TValue> CaptureResult<TValue, TError>(Func<TValue> func, Func<Exception, TError> catchFunc) where TError : ResultError
        {
            try
            {
                return Succeed(func());
            }
            catch(Exception ex)
            {
                return Result<TValue>.Fail(catchFunc(ex));
            }
        }

        public static async Task<Result<TValue>> CaptureResult<TValue, TError>(Func<Task<TValue>> func, Func<Exception, TError> catchFunc) where TError : ResultError
        {
            try
            {
                return Succeed(await func());
            }
            catch(Exception ex)
            {
                return Result<TValue>.Fail(catchFunc(ex));
            }
        }

        Result Then(Func<Result> resultFunc);
        Task<Result> Then(Func<Task<Result>> resultFunc);
        Result<TResultValue> Then<TResultValue>(Func<Result<TResultValue>> resultFunc);
        Task<Result<TResultValue>> Then<TResultValue>(Func<Task<Result<TResultValue>>> resultFunc);
    }

    public interface Result<TValue> : Result
    {
        public new static Result<TValue> Fail<TError>(TError error) where TError : ResultError =>
            new FailureClass<TValue, TError>(error);

        Task<Result> Then(Func<TValue, Task<Result>> resultFunc);
        Result Then(Func<TValue, Result> resultFunc);
        Task<Result<TResultValue>> Then<TResultValue>(Func<TValue, Task<Result<TResultValue>>> resultFunc);
        Result<TResultValue> Then<TResultValue>(Func<TValue, Result<TResultValue>> resultFunc);
    }

    public interface Success : Result
    {
    }

    public interface Success<TValue> : Result<TValue>, Success
    {
        TValue Value { get; }
    }

    public interface Failure : Result
    { 
    }

    public interface Failure<out TError> : Failure where TError : ResultError
    {
        TError Error { get; }
    }

    internal class SuccessClass : Success
    {
        public Result Then(Func<Result> resultFunc) => resultFunc();
        public Task<Result> Then(Func<Task<Result>> resultFunc) => resultFunc();
        public Result<TResultValue> Then<TResultValue>(Func<Result<TResultValue>> resultFunc) => resultFunc();
        public Task<Result<TResultValue>> Then<TResultValue>(Func<Task<Result<TResultValue>>> resultFunc) => resultFunc();
    }

    public static class ResultExtensionMethods
    {
        public static Result OnSuccess(this Result @this, Action func)
        {
            if(@this is Success) func();
            return @this;
        }

        public static async Task<Result> OnSuccess(this Result @this, Func<Task> func)
        {
            if(@this is Success) await func();
            return @this;
        }

        public static Result OnError(this Result @this, Action func)
        {
            if (@this is Failure) func();
            return @this;
        }

        public static async Task<Result> OnError(this Result @this, Func<Task> func)
        {
            if (@this is Failure) await func();
            return @this;
        }

        public static Result OnError<TError>(this Result @this, Action<TError> func) where TError : ResultError
        {
            if (@this is Failure<TError> f) func(f.Error);
            return @this;
        }

        public static async Task<Result> OnError<TError>(this Result @this, Func<TError, Task> func) where TError : ResultError
        {
            if (@this is Failure<TError> f) await func(f.Error);
            return @this;
        }
    }

    public static class ValueResultExtensionMethods
    {
        public static Result<TResultValue> OnSuccess<TResultValue>(this Result<TResultValue> @this, Action func)
        {
            if (@this is Success) func();
            return @this;
        }

        public static async Task<Result<TResultValue>> OnSuccess<TResultValue>(this Result<TResultValue> @this, Func<Task> func)
        {
            if (@this is Success) await func();
            return @this;
        }

        public static Result<TResultValue> OnSuccess<TResultValue>(this Result<TResultValue> @this, Action<TResultValue> func)
        {
            if(@this is Success<TResultValue> s) func(s.Value);
            return @this;
        }

        public static async Task<Result<TResultValue>> OnSuccess<TResultValue>(this Result<TResultValue> @this, Func<TResultValue, Task> func)
        {
            if(@this is Success<TResultValue> s) await func(s.Value);
            return @this;
        }

        public static Result<TResultValue> OnError<TResultValue>(this Result<TResultValue> @this, Action func)
        {
            if (@this is Failure) func();
            return @this;
        }

        public static async Task<Result<TResultValue>> OnError<TResultValue>(this Result<TResultValue> @this, Func<Task> func)
        {
            if (@this is Failure) await func();
            return @this;
        }

        public static Result<TResultValue> OnError<TError, TResultValue>(this Result<TResultValue> @this, Action<TError> func) 
            where TError : ResultError
        {
            if (@this is Failure<TError> f) func(f.Error);
            return @this;
        }

        public static async Task<Result<TResultValue>> OnError<TError, TResultValue>(this Result<TResultValue> @this, Func<TError, Task> func) 
            where TError : ResultError
        {
            if (@this is Failure<TError> f) await func(f.Error);
            return @this;
        }
    }

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
    }

    internal class SuccessClass<TValue> : Success<TValue>
    {
        public TValue Value { get; }

        public SuccessClass(TValue value) => Value = value;

        public Task<Result> Then(Func<TValue, Task<Result>> resultFunc) => resultFunc(Value);
        public Result Then(Func<TValue, Result> resultFunc) => resultFunc(Value);
        public Task<Result<TResultValue>> Then<TResultValue>(Func<TValue, Task<Result<TResultValue>>> resultFunc) => resultFunc(Value);
        public Result<TResultValue> Then<TResultValue>(Func<TValue, Result<TResultValue>> resultFunc) => resultFunc(Value);
        public Result Then(Func<Result> resultFunc) => resultFunc();
        public Task<Result> Then(Func<Task<Result>> resultFunc) => resultFunc();
        public Result<TResultValue> Then<TResultValue>(Func<Result<TResultValue>> resultFunc) => resultFunc();
        public Task<Result<TResultValue>> Then<TResultValue>(Func<Task<Result<TResultValue>>> resultFunc) => resultFunc();
    }

    internal class FailureClass<TValue, TError> : Result<TValue>, Failure<TError> where TError : ResultError
    {
        public TError Error { get; }

        public FailureClass(TError error) => Error = error;

        public Task<Result> Then(Func<TValue, Task<Result>> resultFunc) => this.ToTask<Result>();
        public Result Then(Func<TValue, Result> resultFunc) => this;

        public Task<Result<TResultValue>> Then<TResultValue>(Func<TValue, Task<Result<TResultValue>>> resultFunc) =>
            new FailureClass<TResultValue, TError>(Error).ToTask<Result<TResultValue>>();

        public Result<TResultValue> Then<TResultValue>(Func<TValue, Result<TResultValue>> resultFunc) => 
            new FailureClass<TResultValue, TError>(Error);
        public Result Then(Func<Result> resultFunc) => this;
        public Task<Result> Then(Func<Task<Result>> resultFunc) => this.ToTask<Result>();

        public Result<TResultValue> Then<TResultValue>(Func<Result<TResultValue>> resultFunc) =>
            new FailureClass<TResultValue, TError>(Error);

        public Task<Result<TResultValue>> Then<TResultValue>(Func<Task<Result<TResultValue>>> resultFunc) =>
            new FailureClass<TResultValue, TError>(Error).ToTask<Result<TResultValue>>();

        public Result OnSuccess(Action _) => this;
        public Task<Result> OnSuccess(Func<Task> _) => this.ToTask<Result>();
        public Result<TValue> OnSuccess(Action<TValue> _) => this;
        public Task<Result<TValue>> OnSuccess(Func<TValue, Task> _) => this.ToTask<Result<TValue>>();
    }
}
#pragma warning restore IDE1006 // Naming Styles
