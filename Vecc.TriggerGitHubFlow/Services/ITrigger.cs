using System.Threading.Tasks;
using Vecc.TriggerGitHubFlow.Models;

namespace Vecc.TriggerGitHubFlow.Services
{
    public interface ITrigger
    {
        Task QueueItemAsync(Blob blob);
    }
}
