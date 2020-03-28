using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.IO;
using Exec_resolvido.Entities;


namespace Exec_resolvido {
    class Program {
        static void Main(string[] args)
        {
            Console.Write("Entrar com dado valor:");
            double valor = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Entrar com caminho:");
            String path = Console.ReadLine();
            List<Employee> list = new List<Employee>();

            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    String[] Linha = sr.ReadLine().Split(',');
                    String Name = Linha[0];
                    String Email = Linha[1];
                    Double Salary = double.Parse(Linha[2], CultureInfo.InvariantCulture);
                    list.Add(new Employee(Name, Email, Salary));
                }
            }
            var emails = list.Where(e => e.salary > valor).OrderBy(e => e.name).Select(e=> e.email);
            var soma = list.Where(e => e.name[0] == 'M').Sum(e => e.salary);

            foreach (String e in emails)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine(soma);
            Console.ReadKey();
        }
    }
}
