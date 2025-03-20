using System;
using Spectre.Console;

namespace LevelTwo
{
    public class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length == 2)
            {
                ShowImg(args[0], char.Parse(args[1]));
            }
            else
            {
                ShowImg("tux.jpg", Convert.ToChar(24));
            }
        }

        private static void ShowImg(string imgName, char size)
        {
            CanvasImage img = new CanvasImage(imgName);
            img.MaxWidth(size);
            AnsiConsole.Write(img);
        }
    }
}
