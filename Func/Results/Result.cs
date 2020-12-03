// ReSharper disable InconsistentNaming
#pragma warning disable IDE1006 // Naming Styles
namespace Func
{
    using System;
    using System.Threading.Tasks;

#if !NETSTANDARD2_1
    public static class ResultHelper
#else
    public partial interface Result
#endif
    {
        public static Result Succeed() =>
            new SuccessClass();

        public static Result<TValue> Succeed<TValue>(TValue value) =>
            new SuccessClass<TValue>(value);

        public static Result Fail<TError>(TError error) where TError : ResultError =>
            new FailureClass<object, TError>(error);

        public static Result Fail<TError>() where TError : ResultError, new() =>
            Fail(new TError());

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
#if NETSTANDARD2_1
                return Result<TValue>.Fail(catchFunc(ex));
#else
                return ResultHelper<TValue>.Fail(catchFunc(ex));
#endif
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
#if NETSTANDARD2_1
                return Result<TValue>.Fail(catchFunc(ex));
#else
                return ResultHelper<TValue>.Fail(catchFunc(ex));
#endif
            }
        }
#if !NETSTANDARD2_1
    }

    public partial interface Result
    {
#endif
        Result Then(Func<Result> resultFunc);
        Task<Result> Then(Func<Task<Result>> resultFunc);
        Result<TResultValue> Then<TResultValue>(Func<Result<TResultValue>> resultFunc);
        Task<Result<TResultValue>> Then<TResultValue>(Func<Task<Result<TResultValue>>> resultFunc);
    }

#if NETSTANDARD2_1
    public partial interface Result<TValue> : Result
#else
    public static class ResultHelper<TValue>
#endif
    {
        public new static Result<TValue> Fail<TError>(TError error) where TError : ResultError =>
            new FailureClass<TValue, TError>(error);

        public new static Result<TValue> Fail<TError>() where TError : ResultError, new() =>
            Fail(new TError());
#if !NETSTANDARD2_1
    }

    public partial interface Result<TValue> : Result
    {
#endif
        Task<Result> Then(Func<TValue, Task<Result>> resultFunc);
        Result Then(Func<TValue, Result> resultFunc);
        Task<Result<TResultValue>> Then<TResultValue>(Func<TValue, Task<Result<TResultValue>>> resultFunc);
        Result<TResultValue> Then<TResultValue>(Func<TValue, Result<TResultValue>> resultFunc);

        TValue ValueOr(Func<TValue> onError);
        Task<TValue> ValueOr(Func<Task<TValue>> onError);
    }
}
#pragma warning restore IDE1006 // Naming Styles
