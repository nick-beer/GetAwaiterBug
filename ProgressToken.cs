using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Company.Name
{
    public sealed class ProgressToken
    {
        private readonly TaskCompletionSource<bool> _completion = new TaskCompletionSource<bool>();

        public Task<bool> CompletionTask => _completion.Task;
    }

    public static class ProgressTokenExtensions
    {
        public static TaskAwaiter<bool> GetAwaiter(this ProgressToken token)
            => token.CompletionTask.GetAwaiter();
    }
}
