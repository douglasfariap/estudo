using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp3 {
    class Program {
        static void Main(string[] args)
        {
            string targetPath = @"c:\temp\termo.pdf";
            string[] lines = File.ReadAllLines(targetPath);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
            Console.Read();
        }
    }
}
