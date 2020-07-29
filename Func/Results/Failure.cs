// ReSharper disable InconsistentNaming
#pragma warning disable IDE1006 // Naming Styles
namespace Func
{
    using System;
    using System.Threading.Tasks;

    public interface Failure : Result
    { 
    }

    public interface Failure<out TError> : Failure where TError : ResultError
    {
        TError Error { get; }
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

        public TValue ValueOr(Func<TValue> onError) => onError();
        public Task<TValue> ValueOr(Func<Task<TValue>> onError) => onError();
    }
}
#pragma warning restore IDE1006 // Naming Styles
