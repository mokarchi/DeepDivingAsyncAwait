namespace NetFramework2;

internal class Program
{
    private static void Main(string[] args)
    {
        var example = new AsyncExample();
        example.AsyncCompleted += Example_AsyncCompleted;
        example.DownloadFileAsync("http://example.com/file.txt");

        Console.ReadLine();
    }

    private static void Example_AsyncCompleted(object sender, AsyncCompletedEventArgs e)
    {
        // Handle the completion of the asynchronous operation
        if (e.Cancelled)
        {
            Console.WriteLine("Download was canceled.");
        }
        else if (e.Error != null)
        {
            Console.WriteLine($"Download failed: {e.Error.Message}");
        }
        else
        {
            Console.WriteLine("Download completed successfully.");
        }
    }
}