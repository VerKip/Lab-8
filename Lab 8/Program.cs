using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\veram\OneDrive\Documents\Interior design\Андрей Челюскина";
            string[] files = Directory.GetFiles(path, "*",SearchOption.AllDirectories);
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
            Console.ReadKey();
        }
    }
}
