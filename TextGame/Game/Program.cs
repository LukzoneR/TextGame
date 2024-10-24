﻿using ClassLibrary1;

namespace app;

class Program
{
    static void writing(string text)
    {
        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(100);
        }

    }
    
    static void Main(string[] arg)
    {
                    
    }

    static void Start()
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////game intro

        Console.ForegroundColor = ConsoleColor.Green;

        string[] art = new string[]{

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
        };

        for (int i = 0; i < art.Length; i++)
        {
            if (i > 29)
            {
                Console.WriteLine(art[i]);
                Thread.Sleep(300);
            }
            else
            {
                Console.WriteLine(art[i]);
                Thread.Sleep(40);
            }

        }
        Console.WriteLine();

        Console.ResetColor();

        string IntroText = "Welcome to dark forest, please enter your hero name:";
        writing(IntroText);
        Hero hero = new Hero();
        hero.name = Console.ReadLine();
        Console.WriteLine(hero.name);

    }
}