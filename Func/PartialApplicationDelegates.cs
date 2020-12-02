namespace Func
{
	using System;

	public delegate Func<TArg2, TResult> PartialFunc<in TArg1, in TArg2, out TResult>(TArg1 arg1);
	public delegate Func<TArg3, TResult> PartialFunc<in TArg1, in TArg2, in TArg3, out TResult>(TArg1 arg1, TArg2 arg2);
	public delegate Func<TArg4, TResult> PartialFunc<in TArg1, in TArg2, in TArg3, in TArg4, out TResult>(TArg1 arg1, TArg2 arg2, TArg3 arg3);
	public delegate Func<TArg5, TResult> PartialFunc<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, out TResult>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4);
	public delegate Func<TArg6, TResult> PartialFunc<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, out TResult>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5);
	public delegate Func<TArg7, TResult> PartialFunc<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, out TResult>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6);
	public delegate Func<TArg8, TResult> PartialFunc<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, out TResult>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7);
	public delegate Func<TArg9, TResult> PartialFunc<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, out TResult>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8);
	public delegate Func<TArg10, TResult> PartialFunc<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, out TResult>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9);
	public delegate Func<TArg11, TResult> PartialFunc<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, out TResult>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10);
	public delegate Func<TArg12, TResult> PartialFunc<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, out TResult>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11);
	public delegate Func<TArg13, TResult> PartialFunc<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, out TResult>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12);
	public delegate Func<TArg14, TResult> PartialFunc<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, out TResult>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13);
	public delegate Func<TArg15, TResult> PartialFunc<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, out TResult>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14);
}

