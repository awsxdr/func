// ReSharper disable InconsistentNaming
#pragma warning disable IDE1006 // Naming Styles
namespace Func
{
    using System;
    using System.Threading.Tasks;

    public interface Success : Result
    {
    }

    public interface Success<TValue> : Result<TValue>, Success
    {
        TValue Value { get; }
    }

    internal class SuccessClass : Success
    {
        public Result Then(Func<Result> resultFunc) => resultFunc();
        public Task<Result> Then(Func<Task<Result>> resultFunc) => resultFunc();
        public Result<TResultValue> Then<TResultValue>(Func<Result<TResultValue>> resultFunc) => resultFunc();
        public Task<Result<TResultValue>> Then<TResultValue>(Func<Task<Result<TResultValue>>> resultFunc) => resultFunc();
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
}
#pragma warning restore IDE1006 // Naming Styles
