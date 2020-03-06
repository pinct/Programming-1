using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wallpaper
{
    class Program
    {
        //Michael Courneya - 301106259 - 004
        static void Main(string[] args)
        {
            int length = 15;
            int width = 10;
            int height = 20;
            int ftOfWallpaper = 50;

            Console.WriteLine($"{(2 * length * height + 2* width * height) / ftOfWallpaper} rolls of wallpaper required.");
        }
    }
}
