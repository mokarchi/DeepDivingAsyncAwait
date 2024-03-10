In the .NET Framework 2.0, the `IAsyncResult` interface remains an important part of asynchronous programming, and you can still use it in a similar way as you would in .NET Framework 1.0. The main difference is that in the EAP pattern, the completion of an asynchronous operation is signaled using an event instead of a callback method.

Here's a brief overview of the `IAsyncResult` interface in .NET Framework 2.0:

1. The `System.IAsyncResult` interface represents the status of an asynchronous operation. It provides a way for developers to check the state of an asynchronous operation, wait for its completion, and retrieve its results.
2. The interface includes properties like `IsCompleted` (to check if the operation has completed), `AsyncState` (to store user-defined state information), and `AsyncWaitHandle` (to allow waiting for the operation's completion).
3. The `BeginInvoke` method of a delegate returns an `IAsyncResult` object, which represents the pending asynchronous operation. You can use this object to monitor the operation's progress and handle its completion.

In .NET Framework 2.0, the primary approach for asynchronous programming was using the `IAsyncResult` and `AsyncCallback` model, as well as the Event-based Asynchronous Pattern (EAP) that was introduced in this version. The limitations and challenges of using these approaches in .NET Framework 2.0 include:

1. Complexity: As mentioned earlier, working with `IAsyncResult` and `AsyncCallback` requires a good understanding of delegates, callbacks, and the `IAsyncResult` interface. This can be difficult for developers new to asynchronous programming and may lead to code that is harder to read and maintain.
2. Error handling: Handling exceptions in asynchronous operations can be tricky with this approach. Developers must ensure that exceptions are caught and handled appropriately in the callback method, and that any exceptions thrown during the asynchronous operation are properly communicated back to the callback.
3. Scalability: Managing a large number of concurrent asynchronous operations using the `IAsyncResult` and `AsyncCallback` model can be complex and error-prone, especially when coordinating multiple operations or handling dependencies between them.
4. Lack of built-in cancellation support: The `IAsyncResult` interface does not provide a built-in mechanism for canceling an asynchronous operation. Developers must implement their own cancellation logic, which can lead to inconsistencies and errors.
5. Difficulty in composing asynchronous operations: The model does not provide an easy way to compose multiple asynchronous operations in a sequential or parallel manner. Developers need to write custom code to handle this, which can be complex and difficult to maintain.
6. Limited support for progress reporting: The `IAsyncResult` interface does not have built-in support for reporting progress updates during an asynchronous operation. Developers must implement custom solutions for this functionality.
