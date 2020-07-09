namespace Func
{
    using System.Threading.Tasks;

    public static class TaskExtensionMethods
    {
        public static Task<TResult> ToTask<TResult>(this TResult result) => Task.FromResult(result);
    }
}