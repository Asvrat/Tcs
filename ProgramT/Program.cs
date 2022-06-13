using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramT
{
    public class Program
    {
        static void Main(string[] args)
        {
            string path = "ProgramT\\example.txt";
            if (File.Exists(path))
            {
                System.Console.WriteLine("yes");
            }
            else System.Console.WriteLine("no");
        }
    }
}