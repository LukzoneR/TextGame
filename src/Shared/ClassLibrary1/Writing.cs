
namespace ClassLibrary1;

public class Writing
{
    public static void Print(string text, int time = 60)
    {
        bool isStop = false;
        string writtenText = "";

        foreach (char c in text)
        {
            if(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Spacebar)
            {
                isStop = true;
                break;
            }

            Console.Write(c);
            writtenText += c;
            Thread.Sleep(time);         
        }

        if(isStop)
        {
            string remainingText = text.Substring(writtenText.Length);
            Console.Write(remainingText);
        }
    }
}
