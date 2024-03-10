Here's a brief overview of how asynchronous programming was done in .NET Framework 1.0:


1. To perform an asynchronous operation, a method would typically accept a `AsyncCallback` delegate and a `state` object as parameters. The `AsyncCallback` delegate represented the method to be called when the asynchronous operation completed.
2. The method would then return an `IAsyncResult` object, which represented the ongoing asynchronous operation. The `IAsyncResult` object provided methods to wait for the operation to complete, poll for its completion, and to retrieve the result of the operation.
3. To perform multiple asynchronous operations concurrently, developers would typically use the `AsyncWaitHandle` property of the `IAsyncResult` object to wait for the completion of all operations using the `WaitHandle.WaitAll` method.
4. Once all the operations completed, the developer would use the `EndInvoke` method of the `AsyncCallback` delegate to retrieve the results of the operations.
5. Error handling was done using the `AsyncState` property of the `IAsyncResult` object, which would contain an exception if the operation failed.

