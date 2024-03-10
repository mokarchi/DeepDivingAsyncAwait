using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace NetFramework1;

internal class Program
{
    private static void Main(string[] args)
    {
        string[] urls = ["http://example.com/file1.txt", "http://example.com/file2.txt", "http://example.com/file3.txt"];
        DownloadFilesAsync(urls);
    }

    private static void DownloadFilesAsync(IReadOnlyList<string> urls)
    {
        var results = new IAsyncResult[urls.Count];

        for (var i = 0; i < urls.Count; i++)
        {
            var url = urls[i];
            results[i] = BeginDownloadFile(url, DownloadFileCompleted, url);
        }

        WaitHandle.WaitAll((WaitHandle[])results);
    }

    private static IAsyncResult BeginDownloadFile(string url, AsyncCallback callback, object state)
    {
        var request = WebRequest.Create(url);
        return request.BeginGetResponse(callback, state);
    }

    private static void DownloadFileCompleted(IAsyncResult ar)
    {
        var url = (string)ar.AsyncState;
        var request = (WebRequest)ar.AsyncState;

        using var response = request.EndGetResponse(ar);
        using var responseStream = response.GetResponseStream();
        using var reader = new StreamReader(responseStream);
        var content = reader.ReadToEnd();
        Console.WriteLine($"Downloaded {url} - {content.Length} bytes");
    }
}