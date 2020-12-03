namespace Func
{
	using System;

	public delegate Func<TArg1, TResult> CurriedFunc<in TArg2, in TArg1, out TResult>(TArg2 arg2);
	public delegate Action<TArg1> CurriedAction<in TArg2, in TArg1>(TArg2 arg2);
	public delegate Func<TArg2, Func<TArg1, TResult>> CurriedFunc<in TArg3, in TArg2, in TArg1, out TResult>(TArg3 arg3);
	public delegate Func<TArg2, Action<TArg1>> CurriedAction<in TArg3, in TArg2, in TArg1>(TArg3 arg3);
	public delegate Func<TArg3, Func<TArg2, Func<TArg1, TResult>>> CurriedFunc<in TArg4, in TArg3, in TArg2, in TArg1, out TResult>(TArg4 arg4);
	public delegate Func<TArg3, Func<TArg2, Action<TArg1>>> CurriedAction<in TArg4, in TArg3, in TArg2, in TArg1>(TArg4 arg4);
	public delegate Func<TArg4, Func<TArg3, Func<TArg2, Func<TArg1, TResult>>>> CurriedFunc<in TArg5, in TArg4, in TArg3, in TArg2, in TArg1, out TResult>(TArg5 arg5);
	public delegate Func<TArg4, Func<TArg3, Func<TArg2, Action<TArg1>>>> CurriedAction<in TArg5, in TArg4, in TArg3, in TArg2, in TArg1>(TArg5 arg5);
	public delegate Func<TArg5, Func<TArg4, Func<TArg3, Func<TArg2, Func<TArg1, TResult>>>>> CurriedFunc<in TArg6, in TArg5, in TArg4, in TArg3, in TArg2, in TArg1, out TResult>(TArg6 arg6);
	public delegate Func<TArg5, Func<TArg4, Func<TArg3, Func<TArg2, Action<TArg1>>>>> CurriedAction<in TArg6, in TArg5, in TArg4, in TArg3, in TArg2, in TArg1>(TArg6 arg6);
	public delegate Func<TArg6, Func<TArg5, Func<TArg4, Func<TArg3, Func<TArg2, Func<TArg1, TResult>>>>>> CurriedFunc<in TArg7, in TArg6, in TArg5, in TArg4, in TArg3, in TArg2, in TArg1, out TResult>(TArg7 arg7);
	public delegate Func<TArg6, Func<TArg5, Func<TArg4, Func<TArg3, Func<TArg2, Action<TArg1>>>>>> CurriedAction<in TArg7, in TArg6, in TArg5, in TArg4, in TArg3, in TArg2, in TArg1>(TArg7 arg7);
	public delegate Func<TArg7, Func<TArg6, Func<TArg5, Func<TArg4, Func<TArg3, Func<TArg2, Func<TArg1, TResult>>>>>>> CurriedFunc<in TArg8, in TArg7, in TArg6, in TArg5, in TArg4, in TArg3, in TArg2, in TArg1, out TResult>(TArg8 arg8);
	public delegate Func<TArg7, Func<TArg6, Func<TArg5, Func<TArg4, Func<TArg3, Func<TArg2, Action<TArg1>>>>>>> CurriedAction<in TArg8, in TArg7, in TArg6, in TArg5, in TArg4, in TArg3, in TArg2, in TArg1>(TArg8 arg8);
	public delegate Func<TArg8, Func<TArg7, Func<TArg6, Func<TArg5, Func<TArg4, Func<TArg3, Func<TArg2, Func<TArg1, TResult>>>>>>>> CurriedFunc<in TArg9, in TArg8, in TArg7, in TArg6, in TArg5, in TArg4, in TArg3, in TArg2, in TArg1, out TResult>(TArg9 arg9);
	public delegate Func<TArg8, Func<TArg7, Func<TArg6, Func<TArg5, Func<TArg4, Func<TArg3, Func<TArg2, Action<TArg1>>>>>>>> CurriedAction<in TArg9, in TArg8, in TArg7, in TArg6, in TArg5, in TArg4, in TArg3, in TArg2, in TArg1>(TArg9 arg9);
	public delegate Func<TArg9, Func<TArg8, Func<TArg7, Func<TArg6, Func<TArg5, Func<TArg4, Func<TArg3, Func<TArg2, Func<TArg1, TResult>>>>>>>>> CurriedFunc<in TArg10, in TArg9, in TArg8, in TArg7, in TArg6, in TArg5, in TArg4, in TArg3, in TArg2, in TArg1, out TResult>(TArg10 arg10);
	public delegate Func<TArg9, Func<TArg8, Func<TArg7, Func<TArg6, Func<TArg5, Func<TArg4, Func<TArg3, Func<TArg2, Action<TArg1>>>>>>>>> CurriedAction<in TArg10, in TArg9, in TArg8, in TArg7, in TArg6, in TArg5, in TArg4, in TArg3, in TArg2, in TArg1>(TArg10 arg10);
	public delegate Func<TArg10, Func<TArg9, Func<TArg8, Func<TArg7, Func<TArg6, Func<TArg5, Func<TArg4, Func<TArg3, Func<TArg2, Func<TArg1, TResult>>>>>>>>>> CurriedFunc<in TArg11, in TArg10, in TArg9, in TArg8, in TArg7, in TArg6, in TArg5, in TArg4, in TArg3, in TArg2, in TArg1, out TResult>(TArg11 arg11);
	public delegate Func<TArg10, Func<TArg9, Func<TArg8, Func<TArg7, Func<TArg6, Func<TArg5, Func<TArg4, Func<TArg3, Func<TArg2, Action<TArg1>>>>>>>>>> CurriedAction<in TArg11, in TArg10, in TArg9, in TArg8, in TArg7, in TArg6, in TArg5, in TArg4, in TArg3, in TArg2, in TArg1>(TArg11 arg11);
	public delegate Func<TArg11, Func<TArg10, Func<TArg9, Func<TArg8, Func<TArg7, Func<TArg6, Func<TArg5, Func<TArg4, Func<TArg3, Func<TArg2, Func<TArg1, TResult>>>>>>>>>>> CurriedFunc<in TArg12, in TArg11, in TArg10, in TArg9, in TArg8, in TArg7, in TArg6, in TArg5, in TArg4, in TArg3, in TArg2, in TArg1, out TResult>(TArg12 arg12);
	public delegate Func<TArg11, Func<TArg10, Func<TArg9, Func<TArg8, Func<TArg7, Func<TArg6, Func<TArg5, Func<TArg4, Func<TArg3, Func<TArg2, Action<TArg1>>>>>>>>>>> CurriedAction<in TArg12, in TArg11, in TArg10, in TArg9, in TArg8, in TArg7, in TArg6, in TArg5, in TArg4, in TArg3, in TArg2, in TArg1>(TArg12 arg12);
	public delegate Func<TArg12, Func<TArg11, Func<TArg10, Func<TArg9, Func<TArg8, Func<TArg7, Func<TArg6, Func<TArg5, Func<TArg4, Func<TArg3, Func<TArg2, Func<TArg1, TResult>>>>>>>>>>>> CurriedFunc<in TArg13, in TArg12, in TArg11, in TArg10, in TArg9, in TArg8, in TArg7, in TArg6, in TArg5, in TArg4, in TArg3, in TArg2, in TArg1, out TResult>(TArg13 arg13);
	public delegate Func<TArg12, Func<TArg11, Func<TArg10, Func<TArg9, Func<TArg8, Func<TArg7, Func<TArg6, Func<TArg5, Func<TArg4, Func<TArg3, Func<TArg2, Action<TArg1>>>>>>>>>>>> CurriedAction<in TArg13, in TArg12, in TArg11, in TArg10, in TArg9, in TArg8, in TArg7, in TArg6, in TArg5, in TArg4, in TArg3, in TArg2, in TArg1>(TArg13 arg13);
	public delegate Func<TArg13, Func<TArg12, Func<TArg11, Func<TArg10, Func<TArg9, Func<TArg8, Func<TArg7, Func<TArg6, Func<TArg5, Func<TArg4, Func<TArg3, Func<TArg2, Func<TArg1, TResult>>>>>>>>>>>>> CurriedFunc<in TArg14, in TArg13, in TArg12, in TArg11, in TArg10, in TArg9, in TArg8, in TArg7, in TArg6, in TArg5, in TArg4, in TArg3, in TArg2, in TArg1, out TResult>(TArg14 arg14);
	public delegate Func<TArg13, Func<TArg12, Func<TArg11, Func<TArg10, Func<TArg9, Func<TArg8, Func<TArg7, Func<TArg6, Func<TArg5, Func<TArg4, Func<TArg3, Func<TArg2, Action<TArg1>>>>>>>>>>>>> CurriedAction<in TArg14, in TArg13, in TArg12, in TArg11, in TArg10, in TArg9, in TArg8, in TArg7, in TArg6, in TArg5, in TArg4, in TArg3, in TArg2, in TArg1>(TArg14 arg14);
	public delegate Func<TArg14, Func<TArg13, Func<TArg12, Func<TArg11, Func<TArg10, Func<TArg9, Func<TArg8, Func<TArg7, Func<TArg6, Func<TArg5, Func<TArg4, Func<TArg3, Func<TArg2, Func<TArg1, TResult>>>>>>>>>>>>>> CurriedFunc<in TArg15, in TArg14, in TArg13, in TArg12, in TArg11, in TArg10, in TArg9, in TArg8, in TArg7, in TArg6, in TArg5, in TArg4, in TArg3, in TArg2, in TArg1, out TResult>(TArg15 arg15);
	public delegate Func<TArg14, Func<TArg13, Func<TArg12, Func<TArg11, Func<TArg10, Func<TArg9, Func<TArg8, Func<TArg7, Func<TArg6, Func<TArg5, Func<TArg4, Func<TArg3, Func<TArg2, Action<TArg1>>>>>>>>>>>>>> CurriedAction<in TArg15, in TArg14, in TArg13, in TArg12, in TArg11, in TArg10, in TArg9, in TArg8, in TArg7, in TArg6, in TArg5, in TArg4, in TArg3, in TArg2, in TArg1>(TArg15 arg15);

	public static class Currying
	{	
		public static CurriedFunc<TArg1, TArg2, TResult> Curry<TArg1, TArg2, TResult>(Func<TArg1, TArg2, TResult> func) =>
			value1 => value2 => func(value1, value2);

		public static CurriedAction<TArg1, TArg2> Curry<TArg1, TArg2>(Action<TArg1, TArg2> func) =>
			value1 => value2 => func(value1, value2);

		public static CurriedFunc<TArg1, TArg2, TArg3, TResult> Curry<TArg1, TArg2, TArg3, TResult>(Func<TArg1, TArg2, TArg3, TResult> func) =>
			value1 => value2 => value3 => func(value1, value2, value3);

		public static CurriedAction<TArg1, TArg2, TArg3> Curry<TArg1, TArg2, TArg3>(Action<TArg1, TArg2, TArg3> func) =>
			value1 => value2 => value3 => func(value1, value2, value3);

		public static CurriedFunc<TArg1, TArg2, TArg3, TArg4, TResult> Curry<TArg1, TArg2, TArg3, TArg4, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TResult> func) =>
			value1 => value2 => value3 => value4 => func(value1, value2, value3, value4);

		public static CurriedAction<TArg1, TArg2, TArg3, TArg4> Curry<TArg1, TArg2, TArg3, TArg4>(Action<TArg1, TArg2, TArg3, TArg4> func) =>
			value1 => value2 => value3 => value4 => func(value1, value2, value3, value4);

		public static CurriedFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TResult> Curry<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult> func) =>
			value1 => value2 => value3 => value4 => value5 => func(value1, value2, value3, value4, value5);

		public static CurriedAction<TArg1, TArg2, TArg3, TArg4, TArg5> Curry<TArg1, TArg2, TArg3, TArg4, TArg5>(Action<TArg1, TArg2, TArg3, TArg4, TArg5> func) =>
			value1 => value2 => value3 => value4 => value5 => func(value1, value2, value3, value4, value5);

		public static CurriedFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult> Curry<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult> func) =>
			value1 => value2 => value3 => value4 => value5 => value6 => func(value1, value2, value3, value4, value5, value6);

		public static CurriedAction<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6> Curry<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6> func) =>
			value1 => value2 => value3 => value4 => value5 => value6 => func(value1, value2, value3, value4, value5, value6);

		public static CurriedFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult> Curry<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult> func) =>
			value1 => value2 => value3 => value4 => value5 => value6 => value7 => func(value1, value2, value3, value4, value5, value6, value7);

		public static CurriedAction<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7> Curry<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7> func) =>
			value1 => value2 => value3 => value4 => value5 => value6 => value7 => func(value1, value2, value3, value4, value5, value6, value7);

		public static CurriedFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> Curry<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> func) =>
			value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => func(value1, value2, value3, value4, value5, value6, value7, value8);

		public static CurriedAction<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8> Curry<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8> func) =>
			value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => func(value1, value2, value3, value4, value5, value6, value7, value8);

		public static CurriedFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult> Curry<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult> func) =>
			value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => value9 => func(value1, value2, value3, value4, value5, value6, value7, value8, value9);

		public static CurriedAction<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9> Curry<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>(Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9> func) =>
			value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => value9 => func(value1, value2, value3, value4, value5, value6, value7, value8, value9);

		public static CurriedFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult> Curry<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult> func) =>
			value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => value9 => value10 => func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);

		public static CurriedAction<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10> Curry<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>(Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10> func) =>
			value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => value9 => value10 => func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);

		public static CurriedFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult> Curry<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult> func) =>
			value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => value9 => value10 => value11 => func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);

		public static CurriedAction<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11> Curry<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11> func) =>
			value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => value9 => value10 => value11 => func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);

		public static CurriedFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult> Curry<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult> func) =>
			value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => value9 => value10 => value11 => value12 => func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);

		public static CurriedAction<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12> Curry<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12> func) =>
			value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => value9 => value10 => value11 => value12 => func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);

		public static CurriedFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult> Curry<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult> func) =>
			value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => value9 => value10 => value11 => value12 => value13 => func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);

		public static CurriedAction<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13> Curry<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13> func) =>
			value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => value9 => value10 => value11 => value12 => value13 => func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);

		public static CurriedFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult> Curry<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult> func) =>
			value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => value9 => value10 => value11 => value12 => value13 => value14 => func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);

		public static CurriedAction<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14> Curry<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14> func) =>
			value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => value9 => value10 => value11 => value12 => value13 => value14 => func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);

		public static CurriedFunc<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult> Curry<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult> func) =>
			value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => value9 => value10 => value11 => value12 => value13 => value14 => value15 => func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);

		public static CurriedAction<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15> Curry<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15> func) =>
			value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => value9 => value10 => value11 => value12 => value13 => value14 => value15 => func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);

	}
}
