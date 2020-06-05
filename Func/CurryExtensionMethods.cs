namespace Func
{
	using System;

	public static class Currying
	{	
		public static Func<TValue1, Func<TValue2, TResult>> Curry<TValue1, TValue2, TResult>(Func<TValue1, TValue2, TResult> func) =>
			value1 => value2 => func(value1, value2);

		public static Func<TValue1, Action<TValue2>> Curry<TValue1, TValue2>(Action<TValue1, TValue2> func) =>
			value1 => value2 => func(value1, value2);

		public static Func<TValue1, Func<TValue2, Func<TValue3, TResult>>> Curry<TValue1, TValue2, TValue3, TResult>(Func<TValue1, TValue2, TValue3, TResult> func) =>
			value1 => value2 => value3 => func(value1, value2, value3);

		public static Func<TValue1, Func<TValue2, Action<TValue3>>> Curry<TValue1, TValue2, TValue3>(Action<TValue1, TValue2, TValue3> func) =>
			value1 => value2 => value3 => func(value1, value2, value3);

		public static Func<TValue1, Func<TValue2, Func<TValue3, Func<TValue4, TResult>>>> Curry<TValue1, TValue2, TValue3, TValue4, TResult>(Func<TValue1, TValue2, TValue3, TValue4, TResult> func) =>
			value1 => value2 => value3 => value4 => func(value1, value2, value3, value4);

		public static Func<TValue1, Func<TValue2, Func<TValue3, Action<TValue4>>>> Curry<TValue1, TValue2, TValue3, TValue4>(Action<TValue1, TValue2, TValue3, TValue4> func) =>
			value1 => value2 => value3 => value4 => func(value1, value2, value3, value4);

		public static Func<TValue1, Func<TValue2, Func<TValue3, Func<TValue4, Func<TValue5, TResult>>>>> Curry<TValue1, TValue2, TValue3, TValue4, TValue5, TResult>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, TResult> func) =>
			value1 => value2 => value3 => value4 => value5 => func(value1, value2, value3, value4, value5);

		public static Func<TValue1, Func<TValue2, Func<TValue3, Func<TValue4, Action<TValue5>>>>> Curry<TValue1, TValue2, TValue3, TValue4, TValue5>(Action<TValue1, TValue2, TValue3, TValue4, TValue5> func) =>
			value1 => value2 => value3 => value4 => value5 => func(value1, value2, value3, value4, value5);

		public static Func<TValue1, Func<TValue2, Func<TValue3, Func<TValue4, Func<TValue5, Func<TValue6, TResult>>>>>> Curry<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TResult>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TResult> func) =>
			value1 => value2 => value3 => value4 => value5 => value6 => func(value1, value2, value3, value4, value5, value6);

		public static Func<TValue1, Func<TValue2, Func<TValue3, Func<TValue4, Func<TValue5, Action<TValue6>>>>>> Curry<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6>(Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6> func) =>
			value1 => value2 => value3 => value4 => value5 => value6 => func(value1, value2, value3, value4, value5, value6);

		public static Func<TValue1, Func<TValue2, Func<TValue3, Func<TValue4, Func<TValue5, Func<TValue6, Func<TValue7, TResult>>>>>>> Curry<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TResult>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TResult> func) =>
			value1 => value2 => value3 => value4 => value5 => value6 => value7 => func(value1, value2, value3, value4, value5, value6, value7);

		public static Func<TValue1, Func<TValue2, Func<TValue3, Func<TValue4, Func<TValue5, Func<TValue6, Action<TValue7>>>>>>> Curry<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7>(Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7> func) =>
			value1 => value2 => value3 => value4 => value5 => value6 => value7 => func(value1, value2, value3, value4, value5, value6, value7);

		public static Func<TValue1, Func<TValue2, Func<TValue3, Func<TValue4, Func<TValue5, Func<TValue6, Func<TValue7, Func<TValue8, TResult>>>>>>>> Curry<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TResult>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TResult> func) =>
			value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => func(value1, value2, value3, value4, value5, value6, value7, value8);

		public static Func<TValue1, Func<TValue2, Func<TValue3, Func<TValue4, Func<TValue5, Func<TValue6, Func<TValue7, Action<TValue8>>>>>>>> Curry<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8>(Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8> func) =>
			value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => func(value1, value2, value3, value4, value5, value6, value7, value8);

		public static Func<TValue1, Func<TValue2, Func<TValue3, Func<TValue4, Func<TValue5, Func<TValue6, Func<TValue7, Func<TValue8, Func<TValue9, TResult>>>>>>>>> Curry<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TResult>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TResult> func) =>
			value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => value9 => func(value1, value2, value3, value4, value5, value6, value7, value8, value9);

		public static Func<TValue1, Func<TValue2, Func<TValue3, Func<TValue4, Func<TValue5, Func<TValue6, Func<TValue7, Func<TValue8, Action<TValue9>>>>>>>>> Curry<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9>(Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9> func) =>
			value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => value9 => func(value1, value2, value3, value4, value5, value6, value7, value8, value9);

		public static Func<TValue1, Func<TValue2, Func<TValue3, Func<TValue4, Func<TValue5, Func<TValue6, Func<TValue7, Func<TValue8, Func<TValue9, Func<TValue10, TResult>>>>>>>>>> Curry<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TResult>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TResult> func) =>
			value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => value9 => value10 => func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);

		public static Func<TValue1, Func<TValue2, Func<TValue3, Func<TValue4, Func<TValue5, Func<TValue6, Func<TValue7, Func<TValue8, Func<TValue9, Action<TValue10>>>>>>>>>> Curry<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10>(Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10> func) =>
			value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => value9 => value10 => func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);

		public static Func<TValue1, Func<TValue2, Func<TValue3, Func<TValue4, Func<TValue5, Func<TValue6, Func<TValue7, Func<TValue8, Func<TValue9, Func<TValue10, Func<TValue11, TResult>>>>>>>>>>> Curry<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TResult>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TResult> func) =>
			value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => value9 => value10 => value11 => func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);

		public static Func<TValue1, Func<TValue2, Func<TValue3, Func<TValue4, Func<TValue5, Func<TValue6, Func<TValue7, Func<TValue8, Func<TValue9, Func<TValue10, Action<TValue11>>>>>>>>>>> Curry<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11>(Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11> func) =>
			value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => value9 => value10 => value11 => func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);

		public static Func<TValue1, Func<TValue2, Func<TValue3, Func<TValue4, Func<TValue5, Func<TValue6, Func<TValue7, Func<TValue8, Func<TValue9, Func<TValue10, Func<TValue11, Func<TValue12, TResult>>>>>>>>>>>> Curry<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TResult>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TResult> func) =>
			value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => value9 => value10 => value11 => value12 => func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);

		public static Func<TValue1, Func<TValue2, Func<TValue3, Func<TValue4, Func<TValue5, Func<TValue6, Func<TValue7, Func<TValue8, Func<TValue9, Func<TValue10, Func<TValue11, Action<TValue12>>>>>>>>>>>> Curry<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12>(Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12> func) =>
			value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => value9 => value10 => value11 => value12 => func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);

		public static Func<TValue1, Func<TValue2, Func<TValue3, Func<TValue4, Func<TValue5, Func<TValue6, Func<TValue7, Func<TValue8, Func<TValue9, Func<TValue10, Func<TValue11, Func<TValue12, Func<TValue13, TResult>>>>>>>>>>>>> Curry<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, TResult>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, TResult> func) =>
			value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => value9 => value10 => value11 => value12 => value13 => func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);

		public static Func<TValue1, Func<TValue2, Func<TValue3, Func<TValue4, Func<TValue5, Func<TValue6, Func<TValue7, Func<TValue8, Func<TValue9, Func<TValue10, Func<TValue11, Func<TValue12, Action<TValue13>>>>>>>>>>>>> Curry<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13>(Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13> func) =>
			value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => value9 => value10 => value11 => value12 => value13 => func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);

		public static Func<TValue1, Func<TValue2, Func<TValue3, Func<TValue4, Func<TValue5, Func<TValue6, Func<TValue7, Func<TValue8, Func<TValue9, Func<TValue10, Func<TValue11, Func<TValue12, Func<TValue13, Func<TValue14, TResult>>>>>>>>>>>>>> Curry<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, TValue14, TResult>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, TValue14, TResult> func) =>
			value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => value9 => value10 => value11 => value12 => value13 => value14 => func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);

		public static Func<TValue1, Func<TValue2, Func<TValue3, Func<TValue4, Func<TValue5, Func<TValue6, Func<TValue7, Func<TValue8, Func<TValue9, Func<TValue10, Func<TValue11, Func<TValue12, Func<TValue13, Action<TValue14>>>>>>>>>>>>>> Curry<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, TValue14>(Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, TValue14> func) =>
			value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => value9 => value10 => value11 => value12 => value13 => value14 => func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);

		public static Func<TValue1, Func<TValue2, Func<TValue3, Func<TValue4, Func<TValue5, Func<TValue6, Func<TValue7, Func<TValue8, Func<TValue9, Func<TValue10, Func<TValue11, Func<TValue12, Func<TValue13, Func<TValue14, Func<TValue15, TResult>>>>>>>>>>>>>>> Curry<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, TValue14, TValue15, TResult>(Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, TValue14, TValue15, TResult> func) =>
			value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => value9 => value10 => value11 => value12 => value13 => value14 => value15 => func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);

		public static Func<TValue1, Func<TValue2, Func<TValue3, Func<TValue4, Func<TValue5, Func<TValue6, Func<TValue7, Func<TValue8, Func<TValue9, Func<TValue10, Func<TValue11, Func<TValue12, Func<TValue13, Func<TValue14, Action<TValue15>>>>>>>>>>>>>>> Curry<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, TValue14, TValue15>(Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, TValue14, TValue15> func) =>
			value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => value9 => value10 => value11 => value12 => value13 => value14 => value15 => func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);

	}
}
