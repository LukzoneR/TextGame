
namespace Methods;

public class Title
{
    public string title = @"
                                     _ ,                             
-_____                ,,           ,- -                           ,  
  ' | -,    _         ||          _||_                           ||  
 /| |  |`  < \, ,._-_ ||/\       ' ||    /'\\ ,._-_  _-_   _-_, =||= 
 || |==||  /-||  ||   ||_<         ||   || ||  ||   || \\ ||_.   ||  
~|| |  |, (( ||  ||   || |         |,   || ||  ||   ||/    ~ ||  ||  
 ~-____,   \/\\  \\,  \\,\       _-/    \\,/   \\,  \\,/  ,-_-   \\, 
(                                                                    
                                                                      
    ";


    public void ArtPrint()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(title);
        Console.ResetColor();
        Thread.Sleep(3000);
        Console.Clear();
    }
}
