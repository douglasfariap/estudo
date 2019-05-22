using System;
using System.Collections.Generic;
using System.Globalization;
namespace exex4 {
	class Program {
		static void Main(string[] args) {
			Console.Write("How many employees will be registered? ");
			int n = int.Parse(Console.ReadLine());
			int numero = 1;
			List<Funcionario> employee=new List<Funcionario>();		


			for (int i=0; i < n; i++) {
				Console.WriteLine("Employee #" + numero+":");
				Console.Write("ID: ");
				int id = int.Parse(Console.ReadLine());
				Console.Write("Name: ");
				string name = Console.ReadLine();
				Console.Write("Salary: ");
				double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
				employee.Add(new Funcionario(id, name, salario));
			}

			Console.WriteLine("Enter the employee");
		}
	}
}
