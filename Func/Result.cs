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

        Result OnSuccess(Action func);
        public Result OnError<TError>(Action<TError> func) where TError : ResultError
        {
            if (this is Failure<TError> f) func(f.Error);
            return this;
        }
    }

    public partial interface Result<out TValue> : Result
    {
        public new static Result<TValue> Fail<TError>(TError error) where TError : ResultError =>
            new FailureClass<TValue, TError>(error);

        Task<Result> Then(Func<TValue, Task<Result>> resultFunc);
        Result Then(Func<TValue, Result> resultFunc);
        Task<Result<TResultValue>> Then<TResultValue>(Func<TValue, Task<Result<TResultValue>>> resultFunc);
        Result<TResultValue> Then<TResultValue>(Func<TValue, Result<TResultValue>> resultFunc);

        Result<TValue> OnSuccess(Action<TValue> func);
    }

    public interface Success : Result
    {
    }

    public interface Success<out TValue> : Result<TValue>, Success
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

        public Result OnSuccess(Action func)
        {
            func();
            return this;
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

        public Result OnSuccess(Action func)
        {
            func();
            return this;
        }

        public Result<TValue> OnSuccess(Action<TValue> func)
        {
            func(Value);
            return this;
        }
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

        public Result OnSuccess(Action func) => this;
        public Result<TValue> OnSuccess(Action<TValue> func) => this;
    }
}
#pragma warning restore IDE1006 // Naming Styles
