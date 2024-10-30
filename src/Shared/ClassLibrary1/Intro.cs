
namespace ClassLibrary1;

public class Intro
{
    public string[] art = [

        "████████████▓▓██████████████████████████████████████████████████████████████████▓▓████████████████▓▓▓▓███████████████████████████████████",
        "██████████████████▓▓██▓▓████████████▓▓▒▒▓▓██████████████▓▓██▓▓▓▓████▓▓▓▓██████████████████████▓▓▓▓▓▓▓▓▓▓▓▓███████████████████████████████",
        "██▓▓▓▓████████████████▓▓██████▓▓▓▓████▒▒██▓▓██▓▓▓▓▓▓▓▓████████▓▓▓▓▓▓████▓▓██▓▓████████▓▓▓▓▓▓██▓▓████████████████▓▓███████████████████████",
        "▓▓██████▓▓▓▓▓▓██▓▓▓▓████▓▓██▓▓██▓▓▒▒██▓▓████████▓▓▓▓▓▓██▓▓██▒▒▓▓██▓▓▓▓▓▓▓▓▓▓▓▓██████████▓▓▓▓▓▓▓▓▓▓██░░▒▒▓▓▒▒▓▓▓▓██▓▓██████▓▓█████████████",
        "▓▓░░▓▓████▓▓██▓▓▓▓██████▓▓▓▓░░▓▓░░░░██▒▒▓▓██▓▓▓▓██▓▓██▓▓▓▓██████▓▓▓▓▓▓▒▒▓▓▓▓▓▓▓▓▓▓████▓▓██▓▓▓▓▓▓░░██░░▓▓░░▒▒▓▓▓▓██▓▓▒▒▓▓██▓▓▓▓████▓▓█████",
        "▓▓▒▒▒▒▓▓▒▒▓▓██▓▓▓▓▓▓▓▓▓▓▒▒░░▒▒▒▒▓▓░░░░▓▓████▓▓▓▓▓▓██▓▓▓▓▓▓██████▓▓▒▒▒▒▒▒▒▒▓▓▒▒██▓▓████▓▓▓▓▓▓▓▓▒▒░░██▒▒▓▓░░▒▒▓▓░░▓▓▓▓██▓▓▓▓▓▓██▓▓▓▓██▓▓███",
        "▒▒▒▒░░██░░▓▓▓▓██▒▒████░░░░░░░░░░▒▒░░░░▓▓████░░▒▒▒▒░░▓▓▓▓▓▓██████▓▓▒▒░░▒▒░░▓▓▓▓▓▓▓▓▓▓██▓▓▓▓░░░░████▓▓██▓▓▓▓░░░░░░░░░░▒▒░░░░░░░░▓▓▓▓▓▓██▓▓▓",
        "▒▒▒▒▒▒██▓▓░░▒▒▒▒░░░░░░░░░░░░░░░░░░██▓▓▓▓██▓▓░░░░░░░░░░░░██▓▓██▓▓▒▒░░░░▓▓░░██▓▓████▓▓████░░░░░░▒▒██▓▓▓▓▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓▓▓██▓",
        "░░██▒▒██░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒██▓▓██▓▓░░░░░░░░░░░░░░░░░░▒▒░░░░░░██▒▒▓▓░░░░▓▓░░▓▓░░░░░░░░░░██▓▓▓▓░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒▒",
        "▒▒▓▓██▓▓░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓████▓▓▒▒▓▓████▓▓░░░░░░░░░░░░██▒▒▓▓████░░      ░░░░░░  ░░░░▓▓██▓▓  ░░░░░░██░░░░░░  ░░░░░░░░  ░░░░   ",
        "▓▓████▓▓░░░░░░░░░░░░░░░░░░▓▓▒▒░░░░░░▓▓████▓▓▓▓████▓▓▓▓██░░░░░░░░░░  ▓▓████▓▓░░    ░░      ▒▒▒▒  ▓▓████  ░░▓▓▓▓████▒▒░░░░          ░░░░░░ ",
        "▒▒████▓▓░░░░░░░░░░░░░░░░▓▓▓▓▓▓██▓▓░░██████▓▓▓▓▓▓████▓▓▓▓░░  ░░    ░░░░████▓▓░░░░      ░░      ▓▓▓▓████░░░░██▓▓▓▓▓▓▓▓▓▓░░        ░░▒▒██░░▓",
        "░░▓▓██▓▓░░░░░░░░░░░░░░▒▒▓▓▓▓▓▓▓▓▓▓  ▒▒████▓▓▓▓▓▓██▓▓██▒▒░░  ░░  ░░    ████▓▓░░                ░░████▓▓░░░░░░▓▓▓▓░░  ░░░░        ░░▓▓▓▓▓▓▓",
        "░░▓▓██▓▓░░░░    ░░  ░░░░▓▓▓▓▓▓▓▓▓▓  ▒▒████▒▒▒▒▒▒▓▓░░░░  ░░  ░░        ▓▓██▓▓░░                  ▓▓████▓▓░░        ░░░░░░        ░░▓▓▓▓▓▓█",
        "░░████▓▓  ░░  ░░  ░░░░░░░░▓▓░░░░░░████▓▓████░░  ░░░░░░  ░░░░          ▓▓██▓▓░░        ░░        ▓▓████░░░░          ░░░░        ░░▒▒▓▓▓▓█",
        "░░▓▓██▓▓  ░░░░░░  ░░░░░░░░░░  ░░░░░░████████  ░░░░      ░░░░░░        ▓▓████░░        ░░        ▓▓████░░░░░░    ░░░░░░░░      ░░░░░░░░░░▒",
        "██████▓▓  ░░░░░░░░  ░░░░░░          ▓▓██████  ░░░░      ░░  ░░        ▓▓██▓▓░░        ░░        ▒▒████░░░░        ░░░░░░      ░░░░░░     ",
        "░░██████░░░░░░░░░░░░░░░░░░░░░░  ░░  ▓▓██████░░░░░░░░░░░░░░░░░░░░░░    ██████░░░░░░░░░░░░░░░░    ▓▓████░░░░░░      ░░░░░░  ░░░░░░░░░░░░░░░",
        "░░██████░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓██████░░░░░░░░░░░░░░░░░░░░░░░░░░██████░░░░░░░░░░░░░░░░░░░░██████░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░",
        "░░▓▓██▓▓░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓██████░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓████▒▒░░░░░░░░░░░░░░░░░░▓▓██▓▓░░░░░░░░░░░░░░▒▒░░  ░░░░░░░░░░░░░░░",
        "░░▓▓████░░▒▒▒▒░░░░░░░░░░░░▒▒▒▒▒▒▒▒▒▒████████░░░░░░░░░░░░░░░░▒▒░░░░░░▒▒▓▓████▒▒▒▒▒▒▒▒░░░░░░▒▒▒▒░░▓▓████▒▒▒▒░░▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░▒▒░░░░░",
        "░░▓▓████▒▒▒▒░░▒▒▒▒▒▒▒▒░░▒▒▒▒▒▒▒▒▒▒▒▒▓▓████▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓████▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒",
        "▒▒██████▓▓▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒▒▒▒▒▒▒▒▒▒▒▓▓██████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒▓▓████▓▓▒▒▒▒▓▓▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓▒▒▓▓▒▒▓▓▒▒▒▒▓▓▓▓▒▒▒▒▒▒▒▒▓▓▒▒▒▒▒▒▒▒▒",
        "▓▓██████▓▓▓▓▓▓▒▒▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▓▓▓▓▓▓██▓▓▓▓▓▓▓▓▓▓▒▒▒▒▓▓▓▓▒▒▓▓██▓▓▓▓▓▓▓▓████▓▓▓▓██▓▓▓▓▓▓▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓██▓▓▓▓██▓▓▓▓▒▒▓▓▓▓▓▓██▓▓▓▓▓▓▓▓▓▓▓",
        "██▓▓██▓▓████████▓▓██▓▓▓▓████▓▓██▓▓██▓▓▓▓▓▓████▓▓▓▓▓▓▓▓████▓▓██▓▓▓▓▓▓▓▓████▓▓▓▓██▓▓██▓▓██████▓▓████████▓▓▓▓▓▓▓▓▓▓▓▓████▓▓▓▓██▓▓██████▓▓███",
        "                  ",
        "                   ",
        "░▒▓███████▓▒░ ░▒▓██████▓▒░░▒▓███████▓▒░░▒▓█▓▒░░▒▓█▓▒░      ░▒▓████████▓▒░▒▓██████▓▒░░▒▓███████▓▒░░▒▓████████▓▒░░▒▓███████▓▒░▒▓████████▓▒░",
        "░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░      ░▒▓█▓▒░     ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░         ░▒▓█▓▒░    ",
        "░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░      ░▒▓█▓▒░     ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░         ░▒▓█▓▒░    ",
        "░▒▓█▓▒░░▒▓█▓▒░▒▓████████▓▒░▒▓███████▓▒░░▒▓███████▓▒░       ░▒▓██████▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓███████▓▒░░▒▓██████▓▒░  ░▒▓██████▓▒░   ░▒▓█▓▒░    ",
        "░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░      ░▒▓█▓▒░     ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░             ░▒▓█▓▒░  ░▒▓█▓▒░    ",
        "░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░      ░▒▓█▓▒░     ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░             ░▒▓█▓▒░  ░▒▓█▓▒░    ",
        "░▒▓███████▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░      ░▒▓█▓▒░      ░▒▓██████▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓████████▓▒░▒▓███████▓▒░   ░▒▓█▓▒░    "
        ];

        public void ArtPrint()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;

            for (int i = 0; i < art.Length; i++)
            {
                if (i > 23)
                {
                    Console.WriteLine(art[i]);
                    Thread.Sleep(250);
                }
                else
                {
                    Console.WriteLine(art[i]);
                    Thread.Sleep(40);
                }

            }

            Console.WriteLine();
            Console.ResetColor();
            Thread.Sleep(3000);
            Console.Clear();
        }

}
