namespace Func
{
	using System;
	using System.Threading.Tasks;

	public partial interface Result
	{
		Result Then<TValue1>(Func<TValue1, Result> resultFunc, TValue1 value1);
		Task<Result> Then<TValue1>(Func<TValue1, Task<Result>> resultFunc, TValue1 value1);

		Result<TResultValue> Then<TValue1, TResultValue>(Func<TValue1, Result<TResultValue>> resultFunc, TValue1 value1);
		Task<Result<TResultValue>> Then<TValue1, TResultValue>(Func<TValue1, Task<Result<TResultValue>>> resultFunc, TValue1 value1);

		Result Then<TValue1, TValue2>(Func<TValue1, TValue2, Result> resultFunc, TValue1 value1, TValue2 value2);
		Task<Result> Then<TValue1, TValue2>(Func<TValue1, TValue2, Task<Result>> resultFunc, TValue1 value1, TValue2 value2);

		Result<TResultValue> Then<TValue1, TValue2, TResultValue>(Func<TValue1, TValue2, Result<TResultValue>> resultFunc, TValue1 value1, TValue2 value2);
		Task<Result<TResultValue>> Then<TValue1, TValue2, TResultValue>(Func<TValue1, TValue2, Task<Result<TResultValue>>> resultFunc, TValue1 value1, TValue2 value2);

		Result Then<TValue1, TValue2, TValue3>(Func<TValue1, TValue2, TValue3, Result> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3);
		Task<Result> Then<TValue1, TValue2, TValue3>(Func<TValue1, TValue2, TValue3, Task<Result>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3);

		Result<TResultValue> Then<TValue1, TValue2, TValue3, TResultValue>(Func<TValue1, TValue2, TValue3, Result<TResultValue>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3);
		Task<Result<TResultValue>> Then<TValue1, TValue2, TValue3, TResultValue>(Func<TValue1, TValue2, TValue3, Task<Result<TResultValue>>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3);

		Result Then<TValue1, TValue2, TValue3, TValue4>(Func<TValue1, TValue2, TValue3, TValue4, Result> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4);
		Task<Result> Then<TValue1, TValue2, TValue3, TValue4>(Func<TValue1, TValue2, TValue3, TValue4, Task<Result>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4);

		Result<TResultValue> Then<TValue1, TValue2, TValue3, TValue4, TResultValue>(Func<TValue1, TValue2, TValue3, TValue4, Result<TResultValue>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4);
		Task<Result<TResultValue>> Then<TValue1, TValue2, TValue3, TValue4, TResultValue>(Func<TValue1, TValue2, TValue3, TValue4, Task<Result<TResultValue>>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4);

		Result Then<TValue1, TValue2, TValue3, TValue4, TValue5>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, Result> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5);
		Task<Result> Then<TValue1, TValue2, TValue3, TValue4, TValue5>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task<Result>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5);

		Result<TResultValue> Then<TValue1, TValue2, TValue3, TValue4, TValue5, TResultValue>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, Result<TResultValue>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5);
		Task<Result<TResultValue>> Then<TValue1, TValue2, TValue3, TValue4, TValue5, TResultValue>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task<Result<TResultValue>>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5);

		Result Then<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Result> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6);
		Task<Result> Then<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task<Result>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6);

		Result<TResultValue> Then<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TResultValue>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Result<TResultValue>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6);
		Task<Result<TResultValue>> Then<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TResultValue>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task<Result<TResultValue>>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6);

	}

	public partial interface Result<TValue> : Result
	{
		Task<Result> Then<TValue1>(Func<TValue1, TValue, Task<Result>> resultFunc, TValue1 value1);
		Result Then<TValue1>(Func<TValue1, TValue, Result> resultFunc, TValue1 value1);

		Task<Result<TResultValue>> Then<TValue1, TResultValue>(Func<TValue1, TValue, Task<Result<TResultValue>>> resultFunc, TValue1 value1);
		Result<TResultValue> Then<TValue1, TResultValue>(Func<TValue1, TValue, Result<TResultValue>> resultFunc, TValue1 value1);

		Task<Result> Then<TValue1, TValue2>(Func<TValue1, TValue2, TValue, Task<Result>> resultFunc, TValue1 value1, TValue2 value2);
		Result Then<TValue1, TValue2>(Func<TValue1, TValue2, TValue, Result> resultFunc, TValue1 value1, TValue2 value2);

		Task<Result<TResultValue>> Then<TValue1, TValue2, TResultValue>(Func<TValue1, TValue2, TValue, Task<Result<TResultValue>>> resultFunc, TValue1 value1, TValue2 value2);
		Result<TResultValue> Then<TValue1, TValue2, TResultValue>(Func<TValue1, TValue2, TValue, Result<TResultValue>> resultFunc, TValue1 value1, TValue2 value2);

		Task<Result> Then<TValue1, TValue2, TValue3>(Func<TValue1, TValue2, TValue3, TValue, Task<Result>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3);
		Result Then<TValue1, TValue2, TValue3>(Func<TValue1, TValue2, TValue3, TValue, Result> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3);

		Task<Result<TResultValue>> Then<TValue1, TValue2, TValue3, TResultValue>(Func<TValue1, TValue2, TValue3, TValue, Task<Result<TResultValue>>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3);
		Result<TResultValue> Then<TValue1, TValue2, TValue3, TResultValue>(Func<TValue1, TValue2, TValue3, TValue, Result<TResultValue>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3);

		Task<Result> Then<TValue1, TValue2, TValue3, TValue4>(Func<TValue1, TValue2, TValue3, TValue4, TValue, Task<Result>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4);
		Result Then<TValue1, TValue2, TValue3, TValue4>(Func<TValue1, TValue2, TValue3, TValue4, TValue, Result> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4);

		Task<Result<TResultValue>> Then<TValue1, TValue2, TValue3, TValue4, TResultValue>(Func<TValue1, TValue2, TValue3, TValue4, TValue, Task<Result<TResultValue>>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4);
		Result<TResultValue> Then<TValue1, TValue2, TValue3, TValue4, TResultValue>(Func<TValue1, TValue2, TValue3, TValue4, TValue, Result<TResultValue>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4);

		Task<Result> Then<TValue1, TValue2, TValue3, TValue4, TValue5>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue, Task<Result>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5);
		Result Then<TValue1, TValue2, TValue3, TValue4, TValue5>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue, Result> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5);

		Task<Result<TResultValue>> Then<TValue1, TValue2, TValue3, TValue4, TValue5, TResultValue>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue, Task<Result<TResultValue>>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5);
		Result<TResultValue> Then<TValue1, TValue2, TValue3, TValue4, TValue5, TResultValue>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue, Result<TResultValue>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5);

		Task<Result> Then<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue, Task<Result>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6);
		Result Then<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue, Result> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6);

		Task<Result<TResultValue>> Then<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TResultValue>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue, Task<Result<TResultValue>>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6);
		Result<TResultValue> Then<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TResultValue>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue, Result<TResultValue>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6);

	}

	internal partial class SuccessClass : Success
	{
		public Result Then<TValue1>(Func<TValue1, Result> resultFunc, TValue1 value1) => 
			resultFunc(value1);
		public Task<Result> Then<TValue1>(Func<TValue1, Task<Result>> resultFunc, TValue1 value1) => 
			resultFunc(value1);

		public Result<TResultValue> Then<TValue1, TResultValue>(Func<TValue1, Result<TResultValue>> resultFunc, TValue1 value1) =>
			resultFunc(value1);
		public Task<Result<TResultValue>> Then<TValue1, TResultValue>(Func<TValue1, Task<Result<TResultValue>>> resultFunc, TValue1 value1) =>
			resultFunc(value1);

		public Result Then<TValue1, TValue2>(Func<TValue1, TValue2, Result> resultFunc, TValue1 value1, TValue2 value2) => 
			resultFunc(value1, value2);
		public Task<Result> Then<TValue1, TValue2>(Func<TValue1, TValue2, Task<Result>> resultFunc, TValue1 value1, TValue2 value2) => 
			resultFunc(value1, value2);

		public Result<TResultValue> Then<TValue1, TValue2, TResultValue>(Func<TValue1, TValue2, Result<TResultValue>> resultFunc, TValue1 value1, TValue2 value2) =>
			resultFunc(value1, value2);
		public Task<Result<TResultValue>> Then<TValue1, TValue2, TResultValue>(Func<TValue1, TValue2, Task<Result<TResultValue>>> resultFunc, TValue1 value1, TValue2 value2) =>
			resultFunc(value1, value2);

		public Result Then<TValue1, TValue2, TValue3>(Func<TValue1, TValue2, TValue3, Result> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3) => 
			resultFunc(value1, value2, value3);
		public Task<Result> Then<TValue1, TValue2, TValue3>(Func<TValue1, TValue2, TValue3, Task<Result>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3) => 
			resultFunc(value1, value2, value3);

		public Result<TResultValue> Then<TValue1, TValue2, TValue3, TResultValue>(Func<TValue1, TValue2, TValue3, Result<TResultValue>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3) =>
			resultFunc(value1, value2, value3);
		public Task<Result<TResultValue>> Then<TValue1, TValue2, TValue3, TResultValue>(Func<TValue1, TValue2, TValue3, Task<Result<TResultValue>>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3) =>
			resultFunc(value1, value2, value3);

		public Result Then<TValue1, TValue2, TValue3, TValue4>(Func<TValue1, TValue2, TValue3, TValue4, Result> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4) => 
			resultFunc(value1, value2, value3, value4);
		public Task<Result> Then<TValue1, TValue2, TValue3, TValue4>(Func<TValue1, TValue2, TValue3, TValue4, Task<Result>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4) => 
			resultFunc(value1, value2, value3, value4);

		public Result<TResultValue> Then<TValue1, TValue2, TValue3, TValue4, TResultValue>(Func<TValue1, TValue2, TValue3, TValue4, Result<TResultValue>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4) =>
			resultFunc(value1, value2, value3, value4);
		public Task<Result<TResultValue>> Then<TValue1, TValue2, TValue3, TValue4, TResultValue>(Func<TValue1, TValue2, TValue3, TValue4, Task<Result<TResultValue>>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4) =>
			resultFunc(value1, value2, value3, value4);

		public Result Then<TValue1, TValue2, TValue3, TValue4, TValue5>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, Result> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5) => 
			resultFunc(value1, value2, value3, value4, value5);
		public Task<Result> Then<TValue1, TValue2, TValue3, TValue4, TValue5>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task<Result>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5) => 
			resultFunc(value1, value2, value3, value4, value5);

		public Result<TResultValue> Then<TValue1, TValue2, TValue3, TValue4, TValue5, TResultValue>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, Result<TResultValue>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5) =>
			resultFunc(value1, value2, value3, value4, value5);
		public Task<Result<TResultValue>> Then<TValue1, TValue2, TValue3, TValue4, TValue5, TResultValue>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task<Result<TResultValue>>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5) =>
			resultFunc(value1, value2, value3, value4, value5);

		public Result Then<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Result> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6) => 
			resultFunc(value1, value2, value3, value4, value5, value6);
		public Task<Result> Then<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task<Result>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6) => 
			resultFunc(value1, value2, value3, value4, value5, value6);

		public Result<TResultValue> Then<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TResultValue>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Result<TResultValue>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6) =>
			resultFunc(value1, value2, value3, value4, value5, value6);
		public Task<Result<TResultValue>> Then<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TResultValue>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task<Result<TResultValue>>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6) =>
			resultFunc(value1, value2, value3, value4, value5, value6);

	}

	internal partial class SuccessClass<TValue> : Success<TValue>
	{
		public Task<Result> Then<TValue1>(Func<TValue1, TValue, Task<Result>> resultFunc, TValue1 value1) => 
			resultFunc(value1, Value);
		public Result Then<TValue1>(Func<TValue1, TValue, Result> resultFunc, TValue1 value1) => 
			resultFunc(value1, Value);

		public Task<Result<TResultValue>> Then<TValue1, TResultValue>(Func<TValue1, TValue, Task<Result<TResultValue>>> resultFunc, TValue1 value1) => 
			resultFunc(value1, Value);
		public Result<TResultValue> Then<TValue1, TResultValue>(Func<TValue1, TValue, Result<TResultValue>> resultFunc, TValue1 value1) => 
			resultFunc(value1, Value);

		public Task<Result> Then<TValue1>(Func<TValue1, Task<Result>> resultFunc, TValue1 value1) => 
			resultFunc(value1);
		public Result Then<TValue1>(Func<TValue1, Result> resultFunc, TValue1 value1) => 
			resultFunc(value1);

		public Task<Result<TResultValue>> Then<TValue1, TResultValue>(Func<TValue1, Task<Result<TResultValue>>> resultFunc, TValue1 value1) => 
			resultFunc(value1);
		public Result<TResultValue> Then<TValue1, TResultValue>(Func<TValue1, Result<TResultValue>> resultFunc, TValue1 value1) => 
			resultFunc(value1);

		public Task<Result> Then<TValue1, TValue2>(Func<TValue1, TValue2, TValue, Task<Result>> resultFunc, TValue1 value1, TValue2 value2) => 
			resultFunc(value1, value2, Value);
		public Result Then<TValue1, TValue2>(Func<TValue1, TValue2, TValue, Result> resultFunc, TValue1 value1, TValue2 value2) => 
			resultFunc(value1, value2, Value);

		public Task<Result<TResultValue>> Then<TValue1, TValue2, TResultValue>(Func<TValue1, TValue2, TValue, Task<Result<TResultValue>>> resultFunc, TValue1 value1, TValue2 value2) => 
			resultFunc(value1, value2, Value);
		public Result<TResultValue> Then<TValue1, TValue2, TResultValue>(Func<TValue1, TValue2, TValue, Result<TResultValue>> resultFunc, TValue1 value1, TValue2 value2) => 
			resultFunc(value1, value2, Value);

		public Task<Result> Then<TValue1, TValue2>(Func<TValue1, TValue2, Task<Result>> resultFunc, TValue1 value1, TValue2 value2) => 
			resultFunc(value1, value2);
		public Result Then<TValue1, TValue2>(Func<TValue1, TValue2, Result> resultFunc, TValue1 value1, TValue2 value2) => 
			resultFunc(value1, value2);

		public Task<Result<TResultValue>> Then<TValue1, TValue2, TResultValue>(Func<TValue1, TValue2, Task<Result<TResultValue>>> resultFunc, TValue1 value1, TValue2 value2) => 
			resultFunc(value1, value2);
		public Result<TResultValue> Then<TValue1, TValue2, TResultValue>(Func<TValue1, TValue2, Result<TResultValue>> resultFunc, TValue1 value1, TValue2 value2) => 
			resultFunc(value1, value2);

		public Task<Result> Then<TValue1, TValue2, TValue3>(Func<TValue1, TValue2, TValue3, TValue, Task<Result>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3) => 
			resultFunc(value1, value2, value3, Value);
		public Result Then<TValue1, TValue2, TValue3>(Func<TValue1, TValue2, TValue3, TValue, Result> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3) => 
			resultFunc(value1, value2, value3, Value);

		public Task<Result<TResultValue>> Then<TValue1, TValue2, TValue3, TResultValue>(Func<TValue1, TValue2, TValue3, TValue, Task<Result<TResultValue>>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3) => 
			resultFunc(value1, value2, value3, Value);
		public Result<TResultValue> Then<TValue1, TValue2, TValue3, TResultValue>(Func<TValue1, TValue2, TValue3, TValue, Result<TResultValue>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3) => 
			resultFunc(value1, value2, value3, Value);

		public Task<Result> Then<TValue1, TValue2, TValue3>(Func<TValue1, TValue2, TValue3, Task<Result>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3) => 
			resultFunc(value1, value2, value3);
		public Result Then<TValue1, TValue2, TValue3>(Func<TValue1, TValue2, TValue3, Result> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3) => 
			resultFunc(value1, value2, value3);

		public Task<Result<TResultValue>> Then<TValue1, TValue2, TValue3, TResultValue>(Func<TValue1, TValue2, TValue3, Task<Result<TResultValue>>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3) => 
			resultFunc(value1, value2, value3);
		public Result<TResultValue> Then<TValue1, TValue2, TValue3, TResultValue>(Func<TValue1, TValue2, TValue3, Result<TResultValue>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3) => 
			resultFunc(value1, value2, value3);

		public Task<Result> Then<TValue1, TValue2, TValue3, TValue4>(Func<TValue1, TValue2, TValue3, TValue4, TValue, Task<Result>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4) => 
			resultFunc(value1, value2, value3, value4, Value);
		public Result Then<TValue1, TValue2, TValue3, TValue4>(Func<TValue1, TValue2, TValue3, TValue4, TValue, Result> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4) => 
			resultFunc(value1, value2, value3, value4, Value);

		public Task<Result<TResultValue>> Then<TValue1, TValue2, TValue3, TValue4, TResultValue>(Func<TValue1, TValue2, TValue3, TValue4, TValue, Task<Result<TResultValue>>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4) => 
			resultFunc(value1, value2, value3, value4, Value);
		public Result<TResultValue> Then<TValue1, TValue2, TValue3, TValue4, TResultValue>(Func<TValue1, TValue2, TValue3, TValue4, TValue, Result<TResultValue>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4) => 
			resultFunc(value1, value2, value3, value4, Value);

		public Task<Result> Then<TValue1, TValue2, TValue3, TValue4>(Func<TValue1, TValue2, TValue3, TValue4, Task<Result>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4) => 
			resultFunc(value1, value2, value3, value4);
		public Result Then<TValue1, TValue2, TValue3, TValue4>(Func<TValue1, TValue2, TValue3, TValue4, Result> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4) => 
			resultFunc(value1, value2, value3, value4);

		public Task<Result<TResultValue>> Then<TValue1, TValue2, TValue3, TValue4, TResultValue>(Func<TValue1, TValue2, TValue3, TValue4, Task<Result<TResultValue>>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4) => 
			resultFunc(value1, value2, value3, value4);
		public Result<TResultValue> Then<TValue1, TValue2, TValue3, TValue4, TResultValue>(Func<TValue1, TValue2, TValue3, TValue4, Result<TResultValue>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4) => 
			resultFunc(value1, value2, value3, value4);

		public Task<Result> Then<TValue1, TValue2, TValue3, TValue4, TValue5>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue, Task<Result>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5) => 
			resultFunc(value1, value2, value3, value4, value5, Value);
		public Result Then<TValue1, TValue2, TValue3, TValue4, TValue5>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue, Result> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5) => 
			resultFunc(value1, value2, value3, value4, value5, Value);

		public Task<Result<TResultValue>> Then<TValue1, TValue2, TValue3, TValue4, TValue5, TResultValue>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue, Task<Result<TResultValue>>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5) => 
			resultFunc(value1, value2, value3, value4, value5, Value);
		public Result<TResultValue> Then<TValue1, TValue2, TValue3, TValue4, TValue5, TResultValue>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue, Result<TResultValue>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5) => 
			resultFunc(value1, value2, value3, value4, value5, Value);

		public Task<Result> Then<TValue1, TValue2, TValue3, TValue4, TValue5>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task<Result>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5) => 
			resultFunc(value1, value2, value3, value4, value5);
		public Result Then<TValue1, TValue2, TValue3, TValue4, TValue5>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, Result> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5) => 
			resultFunc(value1, value2, value3, value4, value5);

		public Task<Result<TResultValue>> Then<TValue1, TValue2, TValue3, TValue4, TValue5, TResultValue>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task<Result<TResultValue>>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5) => 
			resultFunc(value1, value2, value3, value4, value5);
		public Result<TResultValue> Then<TValue1, TValue2, TValue3, TValue4, TValue5, TResultValue>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, Result<TResultValue>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5) => 
			resultFunc(value1, value2, value3, value4, value5);

		public Task<Result> Then<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue, Task<Result>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6) => 
			resultFunc(value1, value2, value3, value4, value5, value6, Value);
		public Result Then<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue, Result> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6) => 
			resultFunc(value1, value2, value3, value4, value5, value6, Value);

		public Task<Result<TResultValue>> Then<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TResultValue>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue, Task<Result<TResultValue>>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6) => 
			resultFunc(value1, value2, value3, value4, value5, value6, Value);
		public Result<TResultValue> Then<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TResultValue>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue, Result<TResultValue>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6) => 
			resultFunc(value1, value2, value3, value4, value5, value6, Value);

		public Task<Result> Then<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task<Result>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6) => 
			resultFunc(value1, value2, value3, value4, value5, value6);
		public Result Then<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Result> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6) => 
			resultFunc(value1, value2, value3, value4, value5, value6);

		public Task<Result<TResultValue>> Then<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TResultValue>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task<Result<TResultValue>>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6) => 
			resultFunc(value1, value2, value3, value4, value5, value6);
		public Result<TResultValue> Then<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TResultValue>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Result<TResultValue>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6) => 
			resultFunc(value1, value2, value3, value4, value5, value6);

	}

	internal partial class FailureClass<TValue, TError> : Result<TValue>, Failure<TError> where TError : ResultError
	{
		public Result Then<TValue1>(Func<TValue1, Result> resultFunc, TValue1 value1) => 
			this;
		public Task<Result> Then<TValue1>(Func<TValue1, Task<Result>> resultFunc, TValue1 value1) =>
			this.ToTask<Result>();

		public Result<TResultValue> Then<TValue1, TResultValue>(Func<TValue1, Result<TResultValue>> resultFunc, TValue1 value1) =>
            new FailureClass<TResultValue, TError>(Error);
		public Task<Result<TResultValue>> Then<TValue1, TResultValue>(Func<TValue1, Task<Result<TResultValue>>> resultFunc, TValue1 value1) =>
            new FailureClass<TResultValue, TError>(Error).ToTask<Result<TResultValue>>();

		public Task<Result> Then<TValue1>(Func<TValue1, TValue, Task<Result>> resultFunc, TValue1 value1) =>
			this.ToTask<Result>();
		public Result Then<TValue1>(Func<TValue1, TValue, Result> resultFunc, TValue1 value1) => 
			this;

		public Task<Result<TResultValue>> Then<TValue1, TResultValue>(Func<TValue1, TValue, Task<Result<TResultValue>>> resultFunc, TValue1 value1) =>
            new FailureClass<TResultValue, TError>(Error).ToTask<Result<TResultValue>>();
		public Result<TResultValue> Then<TValue1, TResultValue>(Func<TValue1, TValue, Result<TResultValue>> resultFunc, TValue1 value1) =>
            new FailureClass<TResultValue, TError>(Error);

		public Result Then<TValue1, TValue2>(Func<TValue1, TValue2, Result> resultFunc, TValue1 value1, TValue2 value2) => 
			this;
		public Task<Result> Then<TValue1, TValue2>(Func<TValue1, TValue2, Task<Result>> resultFunc, TValue1 value1, TValue2 value2) =>
			this.ToTask<Result>();

		public Result<TResultValue> Then<TValue1, TValue2, TResultValue>(Func<TValue1, TValue2, Result<TResultValue>> resultFunc, TValue1 value1, TValue2 value2) =>
            new FailureClass<TResultValue, TError>(Error);
		public Task<Result<TResultValue>> Then<TValue1, TValue2, TResultValue>(Func<TValue1, TValue2, Task<Result<TResultValue>>> resultFunc, TValue1 value1, TValue2 value2) =>
            new FailureClass<TResultValue, TError>(Error).ToTask<Result<TResultValue>>();

		public Task<Result> Then<TValue1, TValue2>(Func<TValue1, TValue2, TValue, Task<Result>> resultFunc, TValue1 value1, TValue2 value2) =>
			this.ToTask<Result>();
		public Result Then<TValue1, TValue2>(Func<TValue1, TValue2, TValue, Result> resultFunc, TValue1 value1, TValue2 value2) => 
			this;

		public Task<Result<TResultValue>> Then<TValue1, TValue2, TResultValue>(Func<TValue1, TValue2, TValue, Task<Result<TResultValue>>> resultFunc, TValue1 value1, TValue2 value2) =>
            new FailureClass<TResultValue, TError>(Error).ToTask<Result<TResultValue>>();
		public Result<TResultValue> Then<TValue1, TValue2, TResultValue>(Func<TValue1, TValue2, TValue, Result<TResultValue>> resultFunc, TValue1 value1, TValue2 value2) =>
            new FailureClass<TResultValue, TError>(Error);

		public Result Then<TValue1, TValue2, TValue3>(Func<TValue1, TValue2, TValue3, Result> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3) => 
			this;
		public Task<Result> Then<TValue1, TValue2, TValue3>(Func<TValue1, TValue2, TValue3, Task<Result>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3) =>
			this.ToTask<Result>();

		public Result<TResultValue> Then<TValue1, TValue2, TValue3, TResultValue>(Func<TValue1, TValue2, TValue3, Result<TResultValue>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3) =>
            new FailureClass<TResultValue, TError>(Error);
		public Task<Result<TResultValue>> Then<TValue1, TValue2, TValue3, TResultValue>(Func<TValue1, TValue2, TValue3, Task<Result<TResultValue>>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3) =>
            new FailureClass<TResultValue, TError>(Error).ToTask<Result<TResultValue>>();

		public Task<Result> Then<TValue1, TValue2, TValue3>(Func<TValue1, TValue2, TValue3, TValue, Task<Result>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3) =>
			this.ToTask<Result>();
		public Result Then<TValue1, TValue2, TValue3>(Func<TValue1, TValue2, TValue3, TValue, Result> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3) => 
			this;

		public Task<Result<TResultValue>> Then<TValue1, TValue2, TValue3, TResultValue>(Func<TValue1, TValue2, TValue3, TValue, Task<Result<TResultValue>>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3) =>
            new FailureClass<TResultValue, TError>(Error).ToTask<Result<TResultValue>>();
		public Result<TResultValue> Then<TValue1, TValue2, TValue3, TResultValue>(Func<TValue1, TValue2, TValue3, TValue, Result<TResultValue>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3) =>
            new FailureClass<TResultValue, TError>(Error);

		public Result Then<TValue1, TValue2, TValue3, TValue4>(Func<TValue1, TValue2, TValue3, TValue4, Result> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4) => 
			this;
		public Task<Result> Then<TValue1, TValue2, TValue3, TValue4>(Func<TValue1, TValue2, TValue3, TValue4, Task<Result>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4) =>
			this.ToTask<Result>();

		public Result<TResultValue> Then<TValue1, TValue2, TValue3, TValue4, TResultValue>(Func<TValue1, TValue2, TValue3, TValue4, Result<TResultValue>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4) =>
            new FailureClass<TResultValue, TError>(Error);
		public Task<Result<TResultValue>> Then<TValue1, TValue2, TValue3, TValue4, TResultValue>(Func<TValue1, TValue2, TValue3, TValue4, Task<Result<TResultValue>>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4) =>
            new FailureClass<TResultValue, TError>(Error).ToTask<Result<TResultValue>>();

		public Task<Result> Then<TValue1, TValue2, TValue3, TValue4>(Func<TValue1, TValue2, TValue3, TValue4, TValue, Task<Result>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4) =>
			this.ToTask<Result>();
		public Result Then<TValue1, TValue2, TValue3, TValue4>(Func<TValue1, TValue2, TValue3, TValue4, TValue, Result> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4) => 
			this;

		public Task<Result<TResultValue>> Then<TValue1, TValue2, TValue3, TValue4, TResultValue>(Func<TValue1, TValue2, TValue3, TValue4, TValue, Task<Result<TResultValue>>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4) =>
            new FailureClass<TResultValue, TError>(Error).ToTask<Result<TResultValue>>();
		public Result<TResultValue> Then<TValue1, TValue2, TValue3, TValue4, TResultValue>(Func<TValue1, TValue2, TValue3, TValue4, TValue, Result<TResultValue>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4) =>
            new FailureClass<TResultValue, TError>(Error);

		public Result Then<TValue1, TValue2, TValue3, TValue4, TValue5>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, Result> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5) => 
			this;
		public Task<Result> Then<TValue1, TValue2, TValue3, TValue4, TValue5>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task<Result>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5) =>
			this.ToTask<Result>();

		public Result<TResultValue> Then<TValue1, TValue2, TValue3, TValue4, TValue5, TResultValue>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, Result<TResultValue>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5) =>
            new FailureClass<TResultValue, TError>(Error);
		public Task<Result<TResultValue>> Then<TValue1, TValue2, TValue3, TValue4, TValue5, TResultValue>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task<Result<TResultValue>>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5) =>
            new FailureClass<TResultValue, TError>(Error).ToTask<Result<TResultValue>>();

		public Task<Result> Then<TValue1, TValue2, TValue3, TValue4, TValue5>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue, Task<Result>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5) =>
			this.ToTask<Result>();
		public Result Then<TValue1, TValue2, TValue3, TValue4, TValue5>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue, Result> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5) => 
			this;

		public Task<Result<TResultValue>> Then<TValue1, TValue2, TValue3, TValue4, TValue5, TResultValue>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue, Task<Result<TResultValue>>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5) =>
            new FailureClass<TResultValue, TError>(Error).ToTask<Result<TResultValue>>();
		public Result<TResultValue> Then<TValue1, TValue2, TValue3, TValue4, TValue5, TResultValue>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue, Result<TResultValue>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5) =>
            new FailureClass<TResultValue, TError>(Error);

		public Result Then<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Result> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6) => 
			this;
		public Task<Result> Then<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task<Result>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6) =>
			this.ToTask<Result>();

		public Result<TResultValue> Then<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TResultValue>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Result<TResultValue>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6) =>
            new FailureClass<TResultValue, TError>(Error);
		public Task<Result<TResultValue>> Then<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TResultValue>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task<Result<TResultValue>>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6) =>
            new FailureClass<TResultValue, TError>(Error).ToTask<Result<TResultValue>>();

		public Task<Result> Then<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue, Task<Result>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6) =>
			this.ToTask<Result>();
		public Result Then<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue, Result> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6) => 
			this;

		public Task<Result<TResultValue>> Then<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TResultValue>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue, Task<Result<TResultValue>>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6) =>
            new FailureClass<TResultValue, TError>(Error).ToTask<Result<TResultValue>>();
		public Result<TResultValue> Then<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TResultValue>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue, Result<TResultValue>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6) =>
            new FailureClass<TResultValue, TError>(Error);

	}

	public static class ResultArgumentAdditionExtensions
	{
		public static Task<Result> Then<TValue1>(this Task<Result> @this, Func<TValue1, Task<Result>> resultFunc, TValue1 value1) =>
            @this.ContinueWith(x => x.Result.Then(() => resultFunc(value1))).Unwrap();

		public static Task<Result> Then<TValue1>(this Task<Result> @this, Func<TValue1, Result> resultFunc, TValue1 value1) =>
            @this.ContinueWith(x => x.Result.Then(() => resultFunc(value1)));

		public static Task<Result<TResultValue>> Then<TValue1, TResultValue>(this Task<Result> @this, Func<TValue1, Task<Result<TResultValue>>> resultFunc, TValue1 value1) =>
            @this.ContinueWith(x => x.Result.Then(() => resultFunc(value1))).Unwrap();

		public static Task<Result<TResultValue>> Then<TValue1, TResultValue>(this Task<Result> @this, Func<TValue1, Result<TResultValue>> resultFunc, TValue1 value1) =>
            @this.ContinueWith(x => x.Result.Then(() => resultFunc(value1)));

		public static Task<Result> Then<TValue, TValue1>(this Task<Result<TValue>> @this, Func<TValue1, TValue, Task<Result>> resultFunc, TValue1 value1) =>
            @this.ContinueWith(x => x.Result.Then(value => resultFunc(value1, value))).Unwrap();

		public static Task<Result> Then<TValue, TValue1>(this Task<Result<TValue>> @this, Func<TValue1, TValue, Result> resultFunc, TValue1 value1) =>
            @this.ContinueWith(x => x.Result.Then(value => resultFunc(value1, value)));

		public static Task<Result<TResultValue>> Then<TValue, TValue1, TResultValue>(this Task<Result<TValue>> @this, Func<TValue1, TValue, Task<Result<TResultValue>>> resultFunc, TValue1 value1) =>
            @this.ContinueWith(x => x.Result.Then(value => resultFunc(value1, value))).Unwrap();

		public static Task<Result<TResultValue>> Then<TValue, TValue1, TResultValue>(this Task<Result<TValue>> @this, Func<TValue1, TValue, Result<TResultValue>> resultFunc, TValue1 value1) =>
            @this.ContinueWith(x => x.Result.Then(value => resultFunc(value1, value)));

		public static Task<Result> Then<TValue1, TValue2>(this Task<Result> @this, Func<TValue1, TValue2, Task<Result>> resultFunc, TValue1 value1, TValue2 value2) =>
            @this.ContinueWith(x => x.Result.Then(() => resultFunc(value1, value2))).Unwrap();

		public static Task<Result> Then<TValue1, TValue2>(this Task<Result> @this, Func<TValue1, TValue2, Result> resultFunc, TValue1 value1, TValue2 value2) =>
            @this.ContinueWith(x => x.Result.Then(() => resultFunc(value1, value2)));

		public static Task<Result<TResultValue>> Then<TValue1, TValue2, TResultValue>(this Task<Result> @this, Func<TValue1, TValue2, Task<Result<TResultValue>>> resultFunc, TValue1 value1, TValue2 value2) =>
            @this.ContinueWith(x => x.Result.Then(() => resultFunc(value1, value2))).Unwrap();

		public static Task<Result<TResultValue>> Then<TValue1, TValue2, TResultValue>(this Task<Result> @this, Func<TValue1, TValue2, Result<TResultValue>> resultFunc, TValue1 value1, TValue2 value2) =>
            @this.ContinueWith(x => x.Result.Then(() => resultFunc(value1, value2)));

		public static Task<Result> Then<TValue, TValue1, TValue2>(this Task<Result<TValue>> @this, Func<TValue1, TValue2, TValue, Task<Result>> resultFunc, TValue1 value1, TValue2 value2) =>
            @this.ContinueWith(x => x.Result.Then(value => resultFunc(value1, value2, value))).Unwrap();

		public static Task<Result> Then<TValue, TValue1, TValue2>(this Task<Result<TValue>> @this, Func<TValue1, TValue2, TValue, Result> resultFunc, TValue1 value1, TValue2 value2) =>
            @this.ContinueWith(x => x.Result.Then(value => resultFunc(value1, value2, value)));

		public static Task<Result<TResultValue>> Then<TValue, TValue1, TValue2, TResultValue>(this Task<Result<TValue>> @this, Func<TValue1, TValue2, TValue, Task<Result<TResultValue>>> resultFunc, TValue1 value1, TValue2 value2) =>
            @this.ContinueWith(x => x.Result.Then(value => resultFunc(value1, value2, value))).Unwrap();

		public static Task<Result<TResultValue>> Then<TValue, TValue1, TValue2, TResultValue>(this Task<Result<TValue>> @this, Func<TValue1, TValue2, TValue, Result<TResultValue>> resultFunc, TValue1 value1, TValue2 value2) =>
            @this.ContinueWith(x => x.Result.Then(value => resultFunc(value1, value2, value)));

		public static Task<Result> Then<TValue1, TValue2, TValue3>(this Task<Result> @this, Func<TValue1, TValue2, TValue3, Task<Result>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3) =>
            @this.ContinueWith(x => x.Result.Then(() => resultFunc(value1, value2, value3))).Unwrap();

		public static Task<Result> Then<TValue1, TValue2, TValue3>(this Task<Result> @this, Func<TValue1, TValue2, TValue3, Result> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3) =>
            @this.ContinueWith(x => x.Result.Then(() => resultFunc(value1, value2, value3)));

		public static Task<Result<TResultValue>> Then<TValue1, TValue2, TValue3, TResultValue>(this Task<Result> @this, Func<TValue1, TValue2, TValue3, Task<Result<TResultValue>>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3) =>
            @this.ContinueWith(x => x.Result.Then(() => resultFunc(value1, value2, value3))).Unwrap();

		public static Task<Result<TResultValue>> Then<TValue1, TValue2, TValue3, TResultValue>(this Task<Result> @this, Func<TValue1, TValue2, TValue3, Result<TResultValue>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3) =>
            @this.ContinueWith(x => x.Result.Then(() => resultFunc(value1, value2, value3)));

		public static Task<Result> Then<TValue, TValue1, TValue2, TValue3>(this Task<Result<TValue>> @this, Func<TValue1, TValue2, TValue3, TValue, Task<Result>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3) =>
            @this.ContinueWith(x => x.Result.Then(value => resultFunc(value1, value2, value3, value))).Unwrap();

		public static Task<Result> Then<TValue, TValue1, TValue2, TValue3>(this Task<Result<TValue>> @this, Func<TValue1, TValue2, TValue3, TValue, Result> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3) =>
            @this.ContinueWith(x => x.Result.Then(value => resultFunc(value1, value2, value3, value)));

		public static Task<Result<TResultValue>> Then<TValue, TValue1, TValue2, TValue3, TResultValue>(this Task<Result<TValue>> @this, Func<TValue1, TValue2, TValue3, TValue, Task<Result<TResultValue>>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3) =>
            @this.ContinueWith(x => x.Result.Then(value => resultFunc(value1, value2, value3, value))).Unwrap();

		public static Task<Result<TResultValue>> Then<TValue, TValue1, TValue2, TValue3, TResultValue>(this Task<Result<TValue>> @this, Func<TValue1, TValue2, TValue3, TValue, Result<TResultValue>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3) =>
            @this.ContinueWith(x => x.Result.Then(value => resultFunc(value1, value2, value3, value)));

		public static Task<Result> Then<TValue1, TValue2, TValue3, TValue4>(this Task<Result> @this, Func<TValue1, TValue2, TValue3, TValue4, Task<Result>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4) =>
            @this.ContinueWith(x => x.Result.Then(() => resultFunc(value1, value2, value3, value4))).Unwrap();

		public static Task<Result> Then<TValue1, TValue2, TValue3, TValue4>(this Task<Result> @this, Func<TValue1, TValue2, TValue3, TValue4, Result> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4) =>
            @this.ContinueWith(x => x.Result.Then(() => resultFunc(value1, value2, value3, value4)));

		public static Task<Result<TResultValue>> Then<TValue1, TValue2, TValue3, TValue4, TResultValue>(this Task<Result> @this, Func<TValue1, TValue2, TValue3, TValue4, Task<Result<TResultValue>>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4) =>
            @this.ContinueWith(x => x.Result.Then(() => resultFunc(value1, value2, value3, value4))).Unwrap();

		public static Task<Result<TResultValue>> Then<TValue1, TValue2, TValue3, TValue4, TResultValue>(this Task<Result> @this, Func<TValue1, TValue2, TValue3, TValue4, Result<TResultValue>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4) =>
            @this.ContinueWith(x => x.Result.Then(() => resultFunc(value1, value2, value3, value4)));

		public static Task<Result> Then<TValue, TValue1, TValue2, TValue3, TValue4>(this Task<Result<TValue>> @this, Func<TValue1, TValue2, TValue3, TValue4, TValue, Task<Result>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4) =>
            @this.ContinueWith(x => x.Result.Then(value => resultFunc(value1, value2, value3, value4, value))).Unwrap();

		public static Task<Result> Then<TValue, TValue1, TValue2, TValue3, TValue4>(this Task<Result<TValue>> @this, Func<TValue1, TValue2, TValue3, TValue4, TValue, Result> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4) =>
            @this.ContinueWith(x => x.Result.Then(value => resultFunc(value1, value2, value3, value4, value)));

		public static Task<Result<TResultValue>> Then<TValue, TValue1, TValue2, TValue3, TValue4, TResultValue>(this Task<Result<TValue>> @this, Func<TValue1, TValue2, TValue3, TValue4, TValue, Task<Result<TResultValue>>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4) =>
            @this.ContinueWith(x => x.Result.Then(value => resultFunc(value1, value2, value3, value4, value))).Unwrap();

		public static Task<Result<TResultValue>> Then<TValue, TValue1, TValue2, TValue3, TValue4, TResultValue>(this Task<Result<TValue>> @this, Func<TValue1, TValue2, TValue3, TValue4, TValue, Result<TResultValue>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4) =>
            @this.ContinueWith(x => x.Result.Then(value => resultFunc(value1, value2, value3, value4, value)));

		public static Task<Result> Then<TValue1, TValue2, TValue3, TValue4, TValue5>(this Task<Result> @this, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task<Result>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5) =>
            @this.ContinueWith(x => x.Result.Then(() => resultFunc(value1, value2, value3, value4, value5))).Unwrap();

		public static Task<Result> Then<TValue1, TValue2, TValue3, TValue4, TValue5>(this Task<Result> @this, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Result> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5) =>
            @this.ContinueWith(x => x.Result.Then(() => resultFunc(value1, value2, value3, value4, value5)));

		public static Task<Result<TResultValue>> Then<TValue1, TValue2, TValue3, TValue4, TValue5, TResultValue>(this Task<Result> @this, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task<Result<TResultValue>>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5) =>
            @this.ContinueWith(x => x.Result.Then(() => resultFunc(value1, value2, value3, value4, value5))).Unwrap();

		public static Task<Result<TResultValue>> Then<TValue1, TValue2, TValue3, TValue4, TValue5, TResultValue>(this Task<Result> @this, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Result<TResultValue>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5) =>
            @this.ContinueWith(x => x.Result.Then(() => resultFunc(value1, value2, value3, value4, value5)));

		public static Task<Result> Then<TValue, TValue1, TValue2, TValue3, TValue4, TValue5>(this Task<Result<TValue>> @this, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue, Task<Result>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5) =>
            @this.ContinueWith(x => x.Result.Then(value => resultFunc(value1, value2, value3, value4, value5, value))).Unwrap();

		public static Task<Result> Then<TValue, TValue1, TValue2, TValue3, TValue4, TValue5>(this Task<Result<TValue>> @this, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue, Result> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5) =>
            @this.ContinueWith(x => x.Result.Then(value => resultFunc(value1, value2, value3, value4, value5, value)));

		public static Task<Result<TResultValue>> Then<TValue, TValue1, TValue2, TValue3, TValue4, TValue5, TResultValue>(this Task<Result<TValue>> @this, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue, Task<Result<TResultValue>>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5) =>
            @this.ContinueWith(x => x.Result.Then(value => resultFunc(value1, value2, value3, value4, value5, value))).Unwrap();

		public static Task<Result<TResultValue>> Then<TValue, TValue1, TValue2, TValue3, TValue4, TValue5, TResultValue>(this Task<Result<TValue>> @this, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue, Result<TResultValue>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5) =>
            @this.ContinueWith(x => x.Result.Then(value => resultFunc(value1, value2, value3, value4, value5, value)));

		public static Task<Result> Then<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6>(this Task<Result> @this, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task<Result>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6) =>
            @this.ContinueWith(x => x.Result.Then(() => resultFunc(value1, value2, value3, value4, value5, value6))).Unwrap();

		public static Task<Result> Then<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6>(this Task<Result> @this, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Result> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6) =>
            @this.ContinueWith(x => x.Result.Then(() => resultFunc(value1, value2, value3, value4, value5, value6)));

		public static Task<Result<TResultValue>> Then<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TResultValue>(this Task<Result> @this, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task<Result<TResultValue>>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6) =>
            @this.ContinueWith(x => x.Result.Then(() => resultFunc(value1, value2, value3, value4, value5, value6))).Unwrap();

		public static Task<Result<TResultValue>> Then<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TResultValue>(this Task<Result> @this, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Result<TResultValue>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6) =>
            @this.ContinueWith(x => x.Result.Then(() => resultFunc(value1, value2, value3, value4, value5, value6)));

		public static Task<Result> Then<TValue, TValue1, TValue2, TValue3, TValue4, TValue5, TValue6>(this Task<Result<TValue>> @this, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue, Task<Result>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6) =>
            @this.ContinueWith(x => x.Result.Then(value => resultFunc(value1, value2, value3, value4, value5, value6, value))).Unwrap();

		public static Task<Result> Then<TValue, TValue1, TValue2, TValue3, TValue4, TValue5, TValue6>(this Task<Result<TValue>> @this, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue, Result> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6) =>
            @this.ContinueWith(x => x.Result.Then(value => resultFunc(value1, value2, value3, value4, value5, value6, value)));

		public static Task<Result<TResultValue>> Then<TValue, TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TResultValue>(this Task<Result<TValue>> @this, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue, Task<Result<TResultValue>>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6) =>
            @this.ContinueWith(x => x.Result.Then(value => resultFunc(value1, value2, value3, value4, value5, value6, value))).Unwrap();

		public static Task<Result<TResultValue>> Then<TValue, TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TResultValue>(this Task<Result<TValue>> @this, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue, Result<TResultValue>> resultFunc, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6) =>
            @this.ContinueWith(x => x.Result.Then(value => resultFunc(value1, value2, value3, value4, value5, value6, value)));

	}
}

