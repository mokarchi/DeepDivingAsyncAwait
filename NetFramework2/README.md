In the .NET Framework 2.0, the `IAsyncResult` interface remains an important part of asynchronous programming, and you can still use it in a similar way as you would in .NET Framework 1.0. The main difference is that in the EAP pattern, the completion of an asynchronous operation is signaled using an event instead of a callback method.

Here's a brief overview of the `IAsyncResult` interface in .NET Framework 2.0:

1. The `System.IAsyncResult` interface represents the status of an asynchronous operation. It provides a way for developers to check the state of an asynchronous operation, wait for its completion, and retrieve its results.
2. The interface includes properties like `IsCompleted` (to check if the operation has completed), `AsyncState` (to store user-defined state information), and `AsyncWaitHandle` (to allow waiting for the operation's completion).
3. The `BeginInvoke` method of a delegate returns an `IAsyncResult` object, which represents the pending asynchronous operation. You can use this object to monitor the operation's progress and handle its completion.