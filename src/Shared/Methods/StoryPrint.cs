
namespace Methods;

public class StoryPrint : Writing
{
    public void Write(string text)
    {
        Writing.Print(text);
        Console.ReadKey();
        Console.Clear();
    }
}
