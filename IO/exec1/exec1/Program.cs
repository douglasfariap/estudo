using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace exec1 {
    class Program {
        static void Main(string[] args)
        {
            string source = @"C:\temp\sumario.csv";
            string targetPath = @"C:\temp\out\sumario.csv";
            try { 
                string[] itens = File.ReadAllLines(source);
                using(StreamWriter sw = File.AppendText(targetPath)){
                    foreach(string iten in itens)
                    {
                        string[] a = iten.Split(',');
                        double valor = double.Parse(a[1], CultureInfo.InvariantCulture);
                        int qtd = int.Parse(a[2], CultureInfo.InvariantCulture);
                        valor = valor * qtd;
                        string cl = a[0] + ',' + valor.ToString("F2",CultureInfo.InvariantCulture) ;
                        sw.WriteLine(cl);   
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An error");
                Console.WriteLine( e.Message);
            }
        }
    }
}
