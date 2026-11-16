namespace Agent.Core.Contracts
{
    /// <summary>
    /// A child model the chat host may attach to the chat; the chat runs it alongside itself.
    /// The RPA host plugs the log-analysis panel in through this seam, so the shared
    /// <c>ChatModel</c> never depends on a concrete domain model.
    /// </summary>
    public interface IChatChildModel
    {
        /// <summary>Starts the child model (mirrors <c>BaseModel.Run</c>).</summary>
        void Run();
    }
}
