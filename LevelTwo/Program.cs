using System;
using Spectre.Console;

namespace LevelTwo
{
    public class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length == 2)
                ShowImg(args[0], int.Parse(args[1]));
            else
                ShowImg("tux.jpg", 24);
        }

        private static void ShowImg(string imgName, int size)
        {
            CanvasImage img = new CanvasImage(imgName);
            img.MaxWidth(size);
            AnsiConsole.Write(img);
        }
    }
}
