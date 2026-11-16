using System.Threading;
using System.Threading.Tasks;

namespace Agent.Core.Contracts
{
    /// <summary>
    /// Destination of a prompt built by the model: the chat tab behaves as if the user had typed it.
    /// Implemented by the host; the model never touches the chat collections directly.
    /// </summary>
    public interface IChatPromptSink
    {
        Task SendPromptAsync(string prompt, CancellationToken cancellationToken = default);
    }

    /// <summary>
    /// Non-prompt messages the model wants the user to see (empty source, failed provider call).
    /// Kept separate from <see cref="IChatPromptSink"/> so a fake can record them independently.
    /// </summary>
    public interface IUserMessageSink
    {
        Task NoticeAsync(string message, CancellationToken cancellationToken = default);

        Task ErrorAsync(string message, CancellationToken cancellationToken = default);
    }
}