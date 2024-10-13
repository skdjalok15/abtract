public class Video
{
    private string title;
    private string description;
    private string url;

    public Video(string title, string description, string url)
    {
        this.title = title;
        this.description = description;
        this.url = url;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {title}\nDescription: {description}\nURL: {url}");
    }
}
