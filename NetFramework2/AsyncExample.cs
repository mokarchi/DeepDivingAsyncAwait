namespace NetFramework2;

public class AsyncExample
{
    public event EventHandler<AsyncCompletedEventArgs> AsyncCompleted;

    public void DownloadFileAsync(string url)
    {
        var client = new WebClient();
        client.DownloadFileCompleted += OnDownloadCompleted;
        client.DownloadFileAsync(new Uri(url), "download.txt");
    }

    private void OnDownloadCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
    {
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

        // Notify subscribers that the download has completed
        AsyncCompleted?.Invoke(this, e);
    }
}