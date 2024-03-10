namespace NetFramework2;

public class AsyncCompletedEventArgs(Exception error, bool cancelled, object userState) : EventArgs
{
    public Exception Error { get; } = error;
    public bool Cancelled { get; } = cancelled;
    public object UserState { get; } = userState;
}