






namespace Func
{
	using System;
	using System.Threading.Tasks;
	
	public static class TeeExtensionMethods
	{

		public static Task<TValue1> Tee<TValue1>(this Task<TValue1> valueTask, Func<TValue1, Task> func) =>
			valueTask.ContinueWith(async value1 =>
			{
				await func(value1.Result);
				return value1.Result;
			}).Unwrap();

		public static Task<TValue1> Tee<TValue1>(this Task<TValue1> valueTask, Action<TValue1> func) =>
			valueTask.ContinueWith(value1 =>
			{
				func(value1.Result);
				return value1.Result;
			});

		public static async Task<TValue1> Tee<TValue1>(this TValue1 value1, Func<TValue1, Task> func)
		{
			await func(value1);
			return value1;
		}

		public static TValue1 Tee<TValue1>(this TValue1 value1, Action<TValue1> func)
		{
			func(value1);
			return value1;
		}

		public static Task<TValue1> Tee<TValue1, TIgnored>(this Task<TValue1> valueTask, Func<TValue1, Task<TIgnored>> func) =>
			valueTask.ContinueWith(async value1 =>
			{
				await func(value1.Result);
				return value1.Result;
			}).Unwrap();

		public static Task<TValue1> Tee<TValue1, TIgnored>(this Task<TValue1> valueTask, Func<TValue1, TIgnored> func) =>
			valueTask.ContinueWith(value1 =>
			{
				func(value1.Result);
				return value1.Result;
			});

		public static async Task<TValue1> Tee<TValue1, TIgnored>(this TValue1 value1, Func<TValue1, Task<TIgnored>> func)
		{
			await func(value1);
			return value1;
		}

		public static TValue1 Tee<TValue1, TIgnored>(this TValue1 value1, Func<TValue1, TIgnored> func)
		{
			func(value1);
			return value1;
		}


		public static Task<TValue2> Tee<TValue1, TValue2>(this Task<TValue2> valueTask, Func<TValue1, TValue2, Task> func, TValue1 value1) =>
			valueTask.ContinueWith(async value2 =>
			{
				await func(value1, value2.Result);
				return value2.Result;
			}).Unwrap();

		public static Task<TValue2> Tee<TValue1, TValue2>(this Task<TValue2> valueTask, Action<TValue1, TValue2> func, TValue1 value1) =>
			valueTask.ContinueWith(value2 =>
			{
				func(value1, value2.Result);
				return value2.Result;
			});

		public static async Task<TValue2> Tee<TValue1, TValue2>(this TValue2 value2, Func<TValue1, TValue2, Task> func, TValue1 value1)
		{
			await func(value1, value2);
			return value2;
		}

		public static TValue2 Tee<TValue1, TValue2>(this TValue2 value2, Action<TValue1, TValue2> func, TValue1 value1)
		{
			func(value1, value2);
			return value2;
		}

		public static Task<TValue2> Tee<TValue1, TValue2, TIgnored>(this Task<TValue2> valueTask, Func<TValue1, TValue2, Task<TIgnored>> func, TValue1 value1) =>
			valueTask.ContinueWith(async value2 =>
			{
				await func(value1, value2.Result);
				return value2.Result;
			}).Unwrap();

		public static Task<TValue2> Tee<TValue1, TValue2, TIgnored>(this Task<TValue2> valueTask, Func<TValue1, TValue2, TIgnored> func, TValue1 value1) =>
			valueTask.ContinueWith(value2 =>
			{
				func(value1, value2.Result);
				return value2.Result;
			});

		public static async Task<TValue2> Tee<TValue1, TValue2, TIgnored>(this TValue2 value2, Func<TValue1, TValue2, Task<TIgnored>> func, TValue1 value1)
		{
			await func(value1, value2);
			return value2;
		}

		public static TValue2 Tee<TValue1, TValue2, TIgnored>(this TValue2 value2, Func<TValue1, TValue2, TIgnored> func, TValue1 value1)
		{
			func(value1, value2);
			return value2;
		}


		public static Task<TValue3> Tee<TValue1, TValue2, TValue3>(this Task<TValue3> valueTask, Func<TValue1, TValue2, TValue3, Task> func, TValue1 value1, TValue2 value2) =>
			valueTask.ContinueWith(async value3 =>
			{
				await func(value1, value2, value3.Result);
				return value3.Result;
			}).Unwrap();

		public static Task<TValue3> Tee<TValue1, TValue2, TValue3>(this Task<TValue3> valueTask, Action<TValue1, TValue2, TValue3> func, TValue1 value1, TValue2 value2) =>
			valueTask.ContinueWith(value3 =>
			{
				func(value1, value2, value3.Result);
				return value3.Result;
			});

		public static async Task<TValue3> Tee<TValue1, TValue2, TValue3>(this TValue3 value3, Func<TValue1, TValue2, TValue3, Task> func, TValue1 value1, TValue2 value2)
		{
			await func(value1, value2, value3);
			return value3;
		}

		public static TValue3 Tee<TValue1, TValue2, TValue3>(this TValue3 value3, Action<TValue1, TValue2, TValue3> func, TValue1 value1, TValue2 value2)
		{
			func(value1, value2, value3);
			return value3;
		}

		public static Task<TValue3> Tee<TValue1, TValue2, TValue3, TIgnored>(this Task<TValue3> valueTask, Func<TValue1, TValue2, TValue3, Task<TIgnored>> func, TValue1 value1, TValue2 value2) =>
			valueTask.ContinueWith(async value3 =>
			{
				await func(value1, value2, value3.Result);
				return value3.Result;
			}).Unwrap();

		public static Task<TValue3> Tee<TValue1, TValue2, TValue3, TIgnored>(this Task<TValue3> valueTask, Func<TValue1, TValue2, TValue3, TIgnored> func, TValue1 value1, TValue2 value2) =>
			valueTask.ContinueWith(value3 =>
			{
				func(value1, value2, value3.Result);
				return value3.Result;
			});

		public static async Task<TValue3> Tee<TValue1, TValue2, TValue3, TIgnored>(this TValue3 value3, Func<TValue1, TValue2, TValue3, Task<TIgnored>> func, TValue1 value1, TValue2 value2)
		{
			await func(value1, value2, value3);
			return value3;
		}

		public static TValue3 Tee<TValue1, TValue2, TValue3, TIgnored>(this TValue3 value3, Func<TValue1, TValue2, TValue3, TIgnored> func, TValue1 value1, TValue2 value2)
		{
			func(value1, value2, value3);
			return value3;
		}


		public static Task<TValue4> Tee<TValue1, TValue2, TValue3, TValue4>(this Task<TValue4> valueTask, Func<TValue1, TValue2, TValue3, TValue4, Task> func, TValue1 value1, TValue2 value2, TValue3 value3) =>
			valueTask.ContinueWith(async value4 =>
			{
				await func(value1, value2, value3, value4.Result);
				return value4.Result;
			}).Unwrap();

		public static Task<TValue4> Tee<TValue1, TValue2, TValue3, TValue4>(this Task<TValue4> valueTask, Action<TValue1, TValue2, TValue3, TValue4> func, TValue1 value1, TValue2 value2, TValue3 value3) =>
			valueTask.ContinueWith(value4 =>
			{
				func(value1, value2, value3, value4.Result);
				return value4.Result;
			});

		public static async Task<TValue4> Tee<TValue1, TValue2, TValue3, TValue4>(this TValue4 value4, Func<TValue1, TValue2, TValue3, TValue4, Task> func, TValue1 value1, TValue2 value2, TValue3 value3)
		{
			await func(value1, value2, value3, value4);
			return value4;
		}

		public static TValue4 Tee<TValue1, TValue2, TValue3, TValue4>(this TValue4 value4, Action<TValue1, TValue2, TValue3, TValue4> func, TValue1 value1, TValue2 value2, TValue3 value3)
		{
			func(value1, value2, value3, value4);
			return value4;
		}

		public static Task<TValue4> Tee<TValue1, TValue2, TValue3, TValue4, TIgnored>(this Task<TValue4> valueTask, Func<TValue1, TValue2, TValue3, TValue4, Task<TIgnored>> func, TValue1 value1, TValue2 value2, TValue3 value3) =>
			valueTask.ContinueWith(async value4 =>
			{
				await func(value1, value2, value3, value4.Result);
				return value4.Result;
			}).Unwrap();

		public static Task<TValue4> Tee<TValue1, TValue2, TValue3, TValue4, TIgnored>(this Task<TValue4> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TIgnored> func, TValue1 value1, TValue2 value2, TValue3 value3) =>
			valueTask.ContinueWith(value4 =>
			{
				func(value1, value2, value3, value4.Result);
				return value4.Result;
			});

		public static async Task<TValue4> Tee<TValue1, TValue2, TValue3, TValue4, TIgnored>(this TValue4 value4, Func<TValue1, TValue2, TValue3, TValue4, Task<TIgnored>> func, TValue1 value1, TValue2 value2, TValue3 value3)
		{
			await func(value1, value2, value3, value4);
			return value4;
		}

		public static TValue4 Tee<TValue1, TValue2, TValue3, TValue4, TIgnored>(this TValue4 value4, Func<TValue1, TValue2, TValue3, TValue4, TIgnored> func, TValue1 value1, TValue2 value2, TValue3 value3)
		{
			func(value1, value2, value3, value4);
			return value4;
		}


		public static Task<TValue5> Tee<TValue1, TValue2, TValue3, TValue4, TValue5>(this Task<TValue5> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4) =>
			valueTask.ContinueWith(async value5 =>
			{
				await func(value1, value2, value3, value4, value5.Result);
				return value5.Result;
			}).Unwrap();

		public static Task<TValue5> Tee<TValue1, TValue2, TValue3, TValue4, TValue5>(this Task<TValue5> valueTask, Action<TValue1, TValue2, TValue3, TValue4, TValue5> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4) =>
			valueTask.ContinueWith(value5 =>
			{
				func(value1, value2, value3, value4, value5.Result);
				return value5.Result;
			});

		public static async Task<TValue5> Tee<TValue1, TValue2, TValue3, TValue4, TValue5>(this TValue5 value5, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4)
		{
			await func(value1, value2, value3, value4, value5);
			return value5;
		}

		public static TValue5 Tee<TValue1, TValue2, TValue3, TValue4, TValue5>(this TValue5 value5, Action<TValue1, TValue2, TValue3, TValue4, TValue5> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4)
		{
			func(value1, value2, value3, value4, value5);
			return value5;
		}

		public static Task<TValue5> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TIgnored>(this Task<TValue5> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task<TIgnored>> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4) =>
			valueTask.ContinueWith(async value5 =>
			{
				await func(value1, value2, value3, value4, value5.Result);
				return value5.Result;
			}).Unwrap();

		public static Task<TValue5> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TIgnored>(this Task<TValue5> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TIgnored> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4) =>
			valueTask.ContinueWith(value5 =>
			{
				func(value1, value2, value3, value4, value5.Result);
				return value5.Result;
			});

		public static async Task<TValue5> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TIgnored>(this TValue5 value5, Func<TValue1, TValue2, TValue3, TValue4, TValue5, Task<TIgnored>> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4)
		{
			await func(value1, value2, value3, value4, value5);
			return value5;
		}

		public static TValue5 Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TIgnored>(this TValue5 value5, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TIgnored> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4)
		{
			func(value1, value2, value3, value4, value5);
			return value5;
		}


		public static Task<TValue6> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6>(this Task<TValue6> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5) =>
			valueTask.ContinueWith(async value6 =>
			{
				await func(value1, value2, value3, value4, value5, value6.Result);
				return value6.Result;
			}).Unwrap();

		public static Task<TValue6> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6>(this Task<TValue6> valueTask, Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5) =>
			valueTask.ContinueWith(value6 =>
			{
				func(value1, value2, value3, value4, value5, value6.Result);
				return value6.Result;
			});

		public static async Task<TValue6> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6>(this TValue6 value6, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5)
		{
			await func(value1, value2, value3, value4, value5, value6);
			return value6;
		}

		public static TValue6 Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6>(this TValue6 value6, Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5)
		{
			func(value1, value2, value3, value4, value5, value6);
			return value6;
		}

		public static Task<TValue6> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TIgnored>(this Task<TValue6> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task<TIgnored>> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5) =>
			valueTask.ContinueWith(async value6 =>
			{
				await func(value1, value2, value3, value4, value5, value6.Result);
				return value6.Result;
			}).Unwrap();

		public static Task<TValue6> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TIgnored>(this Task<TValue6> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TIgnored> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5) =>
			valueTask.ContinueWith(value6 =>
			{
				func(value1, value2, value3, value4, value5, value6.Result);
				return value6.Result;
			});

		public static async Task<TValue6> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TIgnored>(this TValue6 value6, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, Task<TIgnored>> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5)
		{
			await func(value1, value2, value3, value4, value5, value6);
			return value6;
		}

		public static TValue6 Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TIgnored>(this TValue6 value6, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TIgnored> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5)
		{
			func(value1, value2, value3, value4, value5, value6);
			return value6;
		}


		public static Task<TValue7> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7>(this Task<TValue7> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, Task> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6) =>
			valueTask.ContinueWith(async value7 =>
			{
				await func(value1, value2, value3, value4, value5, value6, value7.Result);
				return value7.Result;
			}).Unwrap();

		public static Task<TValue7> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7>(this Task<TValue7> valueTask, Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6) =>
			valueTask.ContinueWith(value7 =>
			{
				func(value1, value2, value3, value4, value5, value6, value7.Result);
				return value7.Result;
			});

		public static async Task<TValue7> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7>(this TValue7 value7, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, Task> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6)
		{
			await func(value1, value2, value3, value4, value5, value6, value7);
			return value7;
		}

		public static TValue7 Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7>(this TValue7 value7, Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6)
		{
			func(value1, value2, value3, value4, value5, value6, value7);
			return value7;
		}

		public static Task<TValue7> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TIgnored>(this Task<TValue7> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, Task<TIgnored>> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6) =>
			valueTask.ContinueWith(async value7 =>
			{
				await func(value1, value2, value3, value4, value5, value6, value7.Result);
				return value7.Result;
			}).Unwrap();

		public static Task<TValue7> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TIgnored>(this Task<TValue7> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TIgnored> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6) =>
			valueTask.ContinueWith(value7 =>
			{
				func(value1, value2, value3, value4, value5, value6, value7.Result);
				return value7.Result;
			});

		public static async Task<TValue7> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TIgnored>(this TValue7 value7, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, Task<TIgnored>> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6)
		{
			await func(value1, value2, value3, value4, value5, value6, value7);
			return value7;
		}

		public static TValue7 Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TIgnored>(this TValue7 value7, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TIgnored> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6)
		{
			func(value1, value2, value3, value4, value5, value6, value7);
			return value7;
		}


		public static Task<TValue8> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8>(this Task<TValue8> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, Task> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7) =>
			valueTask.ContinueWith(async value8 =>
			{
				await func(value1, value2, value3, value4, value5, value6, value7, value8.Result);
				return value8.Result;
			}).Unwrap();

		public static Task<TValue8> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8>(this Task<TValue8> valueTask, Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7) =>
			valueTask.ContinueWith(value8 =>
			{
				func(value1, value2, value3, value4, value5, value6, value7, value8.Result);
				return value8.Result;
			});

		public static async Task<TValue8> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8>(this TValue8 value8, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, Task> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7)
		{
			await func(value1, value2, value3, value4, value5, value6, value7, value8);
			return value8;
		}

		public static TValue8 Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8>(this TValue8 value8, Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7)
		{
			func(value1, value2, value3, value4, value5, value6, value7, value8);
			return value8;
		}

		public static Task<TValue8> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TIgnored>(this Task<TValue8> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, Task<TIgnored>> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7) =>
			valueTask.ContinueWith(async value8 =>
			{
				await func(value1, value2, value3, value4, value5, value6, value7, value8.Result);
				return value8.Result;
			}).Unwrap();

		public static Task<TValue8> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TIgnored>(this Task<TValue8> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TIgnored> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7) =>
			valueTask.ContinueWith(value8 =>
			{
				func(value1, value2, value3, value4, value5, value6, value7, value8.Result);
				return value8.Result;
			});

		public static async Task<TValue8> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TIgnored>(this TValue8 value8, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, Task<TIgnored>> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7)
		{
			await func(value1, value2, value3, value4, value5, value6, value7, value8);
			return value8;
		}

		public static TValue8 Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TIgnored>(this TValue8 value8, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TIgnored> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7)
		{
			func(value1, value2, value3, value4, value5, value6, value7, value8);
			return value8;
		}


		public static Task<TValue9> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9>(this Task<TValue9> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, Task> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8) =>
			valueTask.ContinueWith(async value9 =>
			{
				await func(value1, value2, value3, value4, value5, value6, value7, value8, value9.Result);
				return value9.Result;
			}).Unwrap();

		public static Task<TValue9> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9>(this Task<TValue9> valueTask, Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8) =>
			valueTask.ContinueWith(value9 =>
			{
				func(value1, value2, value3, value4, value5, value6, value7, value8, value9.Result);
				return value9.Result;
			});

		public static async Task<TValue9> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9>(this TValue9 value9, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, Task> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8)
		{
			await func(value1, value2, value3, value4, value5, value6, value7, value8, value9);
			return value9;
		}

		public static TValue9 Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9>(this TValue9 value9, Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8)
		{
			func(value1, value2, value3, value4, value5, value6, value7, value8, value9);
			return value9;
		}

		public static Task<TValue9> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TIgnored>(this Task<TValue9> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, Task<TIgnored>> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8) =>
			valueTask.ContinueWith(async value9 =>
			{
				await func(value1, value2, value3, value4, value5, value6, value7, value8, value9.Result);
				return value9.Result;
			}).Unwrap();

		public static Task<TValue9> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TIgnored>(this Task<TValue9> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TIgnored> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8) =>
			valueTask.ContinueWith(value9 =>
			{
				func(value1, value2, value3, value4, value5, value6, value7, value8, value9.Result);
				return value9.Result;
			});

		public static async Task<TValue9> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TIgnored>(this TValue9 value9, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, Task<TIgnored>> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8)
		{
			await func(value1, value2, value3, value4, value5, value6, value7, value8, value9);
			return value9;
		}

		public static TValue9 Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TIgnored>(this TValue9 value9, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TIgnored> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8)
		{
			func(value1, value2, value3, value4, value5, value6, value7, value8, value9);
			return value9;
		}


		public static Task<TValue10> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10>(this Task<TValue10> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, Task> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9) =>
			valueTask.ContinueWith(async value10 =>
			{
				await func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10.Result);
				return value10.Result;
			}).Unwrap();

		public static Task<TValue10> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10>(this Task<TValue10> valueTask, Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9) =>
			valueTask.ContinueWith(value10 =>
			{
				func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10.Result);
				return value10.Result;
			});

		public static async Task<TValue10> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10>(this TValue10 value10, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, Task> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9)
		{
			await func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);
			return value10;
		}

		public static TValue10 Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10>(this TValue10 value10, Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9)
		{
			func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);
			return value10;
		}

		public static Task<TValue10> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TIgnored>(this Task<TValue10> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, Task<TIgnored>> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9) =>
			valueTask.ContinueWith(async value10 =>
			{
				await func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10.Result);
				return value10.Result;
			}).Unwrap();

		public static Task<TValue10> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TIgnored>(this Task<TValue10> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TIgnored> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9) =>
			valueTask.ContinueWith(value10 =>
			{
				func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10.Result);
				return value10.Result;
			});

		public static async Task<TValue10> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TIgnored>(this TValue10 value10, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, Task<TIgnored>> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9)
		{
			await func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);
			return value10;
		}

		public static TValue10 Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TIgnored>(this TValue10 value10, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TIgnored> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9)
		{
			func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);
			return value10;
		}


		public static Task<TValue11> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11>(this Task<TValue11> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, Task> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9, TValue10 value10) =>
			valueTask.ContinueWith(async value11 =>
			{
				await func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11.Result);
				return value11.Result;
			}).Unwrap();

		public static Task<TValue11> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11>(this Task<TValue11> valueTask, Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9, TValue10 value10) =>
			valueTask.ContinueWith(value11 =>
			{
				func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11.Result);
				return value11.Result;
			});

		public static async Task<TValue11> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11>(this TValue11 value11, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, Task> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9, TValue10 value10)
		{
			await func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);
			return value11;
		}

		public static TValue11 Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11>(this TValue11 value11, Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9, TValue10 value10)
		{
			func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);
			return value11;
		}

		public static Task<TValue11> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TIgnored>(this Task<TValue11> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, Task<TIgnored>> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9, TValue10 value10) =>
			valueTask.ContinueWith(async value11 =>
			{
				await func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11.Result);
				return value11.Result;
			}).Unwrap();

		public static Task<TValue11> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TIgnored>(this Task<TValue11> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TIgnored> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9, TValue10 value10) =>
			valueTask.ContinueWith(value11 =>
			{
				func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11.Result);
				return value11.Result;
			});

		public static async Task<TValue11> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TIgnored>(this TValue11 value11, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, Task<TIgnored>> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9, TValue10 value10)
		{
			await func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);
			return value11;
		}

		public static TValue11 Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TIgnored>(this TValue11 value11, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TIgnored> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9, TValue10 value10)
		{
			func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);
			return value11;
		}


		public static Task<TValue12> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12>(this Task<TValue12> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, Task> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9, TValue10 value10, TValue11 value11) =>
			valueTask.ContinueWith(async value12 =>
			{
				await func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12.Result);
				return value12.Result;
			}).Unwrap();

		public static Task<TValue12> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12>(this Task<TValue12> valueTask, Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9, TValue10 value10, TValue11 value11) =>
			valueTask.ContinueWith(value12 =>
			{
				func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12.Result);
				return value12.Result;
			});

		public static async Task<TValue12> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12>(this TValue12 value12, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, Task> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9, TValue10 value10, TValue11 value11)
		{
			await func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);
			return value12;
		}

		public static TValue12 Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12>(this TValue12 value12, Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9, TValue10 value10, TValue11 value11)
		{
			func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);
			return value12;
		}

		public static Task<TValue12> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TIgnored>(this Task<TValue12> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, Task<TIgnored>> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9, TValue10 value10, TValue11 value11) =>
			valueTask.ContinueWith(async value12 =>
			{
				await func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12.Result);
				return value12.Result;
			}).Unwrap();

		public static Task<TValue12> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TIgnored>(this Task<TValue12> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TIgnored> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9, TValue10 value10, TValue11 value11) =>
			valueTask.ContinueWith(value12 =>
			{
				func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12.Result);
				return value12.Result;
			});

		public static async Task<TValue12> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TIgnored>(this TValue12 value12, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, Task<TIgnored>> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9, TValue10 value10, TValue11 value11)
		{
			await func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);
			return value12;
		}

		public static TValue12 Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TIgnored>(this TValue12 value12, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TIgnored> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9, TValue10 value10, TValue11 value11)
		{
			func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);
			return value12;
		}


		public static Task<TValue13> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13>(this Task<TValue13> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, Task> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9, TValue10 value10, TValue11 value11, TValue12 value12) =>
			valueTask.ContinueWith(async value13 =>
			{
				await func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13.Result);
				return value13.Result;
			}).Unwrap();

		public static Task<TValue13> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13>(this Task<TValue13> valueTask, Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9, TValue10 value10, TValue11 value11, TValue12 value12) =>
			valueTask.ContinueWith(value13 =>
			{
				func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13.Result);
				return value13.Result;
			});

		public static async Task<TValue13> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13>(this TValue13 value13, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, Task> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9, TValue10 value10, TValue11 value11, TValue12 value12)
		{
			await func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);
			return value13;
		}

		public static TValue13 Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13>(this TValue13 value13, Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9, TValue10 value10, TValue11 value11, TValue12 value12)
		{
			func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);
			return value13;
		}

		public static Task<TValue13> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, TIgnored>(this Task<TValue13> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, Task<TIgnored>> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9, TValue10 value10, TValue11 value11, TValue12 value12) =>
			valueTask.ContinueWith(async value13 =>
			{
				await func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13.Result);
				return value13.Result;
			}).Unwrap();

		public static Task<TValue13> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, TIgnored>(this Task<TValue13> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, TIgnored> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9, TValue10 value10, TValue11 value11, TValue12 value12) =>
			valueTask.ContinueWith(value13 =>
			{
				func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13.Result);
				return value13.Result;
			});

		public static async Task<TValue13> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, TIgnored>(this TValue13 value13, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, Task<TIgnored>> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9, TValue10 value10, TValue11 value11, TValue12 value12)
		{
			await func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);
			return value13;
		}

		public static TValue13 Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, TIgnored>(this TValue13 value13, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, TIgnored> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9, TValue10 value10, TValue11 value11, TValue12 value12)
		{
			func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);
			return value13;
		}


		public static Task<TValue14> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, TValue14>(this Task<TValue14> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, TValue14, Task> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9, TValue10 value10, TValue11 value11, TValue12 value12, TValue13 value13) =>
			valueTask.ContinueWith(async value14 =>
			{
				await func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14.Result);
				return value14.Result;
			}).Unwrap();

		public static Task<TValue14> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, TValue14>(this Task<TValue14> valueTask, Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, TValue14> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9, TValue10 value10, TValue11 value11, TValue12 value12, TValue13 value13) =>
			valueTask.ContinueWith(value14 =>
			{
				func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14.Result);
				return value14.Result;
			});

		public static async Task<TValue14> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, TValue14>(this TValue14 value14, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, TValue14, Task> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9, TValue10 value10, TValue11 value11, TValue12 value12, TValue13 value13)
		{
			await func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);
			return value14;
		}

		public static TValue14 Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, TValue14>(this TValue14 value14, Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, TValue14> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9, TValue10 value10, TValue11 value11, TValue12 value12, TValue13 value13)
		{
			func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);
			return value14;
		}

		public static Task<TValue14> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, TValue14, TIgnored>(this Task<TValue14> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, TValue14, Task<TIgnored>> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9, TValue10 value10, TValue11 value11, TValue12 value12, TValue13 value13) =>
			valueTask.ContinueWith(async value14 =>
			{
				await func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14.Result);
				return value14.Result;
			}).Unwrap();

		public static Task<TValue14> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, TValue14, TIgnored>(this Task<TValue14> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, TValue14, TIgnored> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9, TValue10 value10, TValue11 value11, TValue12 value12, TValue13 value13) =>
			valueTask.ContinueWith(value14 =>
			{
				func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14.Result);
				return value14.Result;
			});

		public static async Task<TValue14> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, TValue14, TIgnored>(this TValue14 value14, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, TValue14, Task<TIgnored>> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9, TValue10 value10, TValue11 value11, TValue12 value12, TValue13 value13)
		{
			await func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);
			return value14;
		}

		public static TValue14 Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, TValue14, TIgnored>(this TValue14 value14, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, TValue14, TIgnored> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9, TValue10 value10, TValue11 value11, TValue12 value12, TValue13 value13)
		{
			func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);
			return value14;
		}


		public static Task<TValue15> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, TValue14, TValue15>(this Task<TValue15> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, TValue14, TValue15, Task> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9, TValue10 value10, TValue11 value11, TValue12 value12, TValue13 value13, TValue14 value14) =>
			valueTask.ContinueWith(async value15 =>
			{
				await func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15.Result);
				return value15.Result;
			}).Unwrap();

		public static Task<TValue15> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, TValue14, TValue15>(this Task<TValue15> valueTask, Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, TValue14, TValue15> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9, TValue10 value10, TValue11 value11, TValue12 value12, TValue13 value13, TValue14 value14) =>
			valueTask.ContinueWith(value15 =>
			{
				func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15.Result);
				return value15.Result;
			});

		public static async Task<TValue15> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, TValue14, TValue15>(this TValue15 value15, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, TValue14, TValue15, Task> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9, TValue10 value10, TValue11 value11, TValue12 value12, TValue13 value13, TValue14 value14)
		{
			await func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);
			return value15;
		}

		public static TValue15 Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, TValue14, TValue15>(this TValue15 value15, Action<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, TValue14, TValue15> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9, TValue10 value10, TValue11 value11, TValue12 value12, TValue13 value13, TValue14 value14)
		{
			func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);
			return value15;
		}

		public static Task<TValue15> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, TValue14, TValue15, TIgnored>(this Task<TValue15> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, TValue14, TValue15, Task<TIgnored>> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9, TValue10 value10, TValue11 value11, TValue12 value12, TValue13 value13, TValue14 value14) =>
			valueTask.ContinueWith(async value15 =>
			{
				await func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15.Result);
				return value15.Result;
			}).Unwrap();

		public static Task<TValue15> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, TValue14, TValue15, TIgnored>(this Task<TValue15> valueTask, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, TValue14, TValue15, TIgnored> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9, TValue10 value10, TValue11 value11, TValue12 value12, TValue13 value13, TValue14 value14) =>
			valueTask.ContinueWith(value15 =>
			{
				func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15.Result);
				return value15.Result;
			});

		public static async Task<TValue15> Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, TValue14, TValue15, TIgnored>(this TValue15 value15, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, TValue14, TValue15, Task<TIgnored>> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9, TValue10 value10, TValue11 value11, TValue12 value12, TValue13 value13, TValue14 value14)
		{
			await func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);
			return value15;
		}

		public static TValue15 Tee<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, TValue14, TValue15, TIgnored>(this TValue15 value15, Func<TValue1, TValue2, TValue3, TValue4, TValue5, TValue6, TValue7, TValue8, TValue9, TValue10, TValue11, TValue12, TValue13, TValue14, TValue15, TIgnored> func, TValue1 value1, TValue2 value2, TValue3 value3, TValue4 value4, TValue5 value5, TValue6 value6, TValue7 value7, TValue8 value8, TValue9 value9, TValue10 value10, TValue11 value11, TValue12 value12, TValue13 value13, TValue14 value14)
		{
			func(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);
			return value15;
		}


	}
}

