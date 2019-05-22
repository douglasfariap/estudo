using System;
using System.Globalization;

namespace fun3 {
	class Program {
		static void Main(string[] args) {
			Aluno aluno = new Aluno();

			Console.WriteLine("Digite o Nome do Aluno: ");
			aluno.Nome = Console.ReadLine();
			Console.WriteLine("Digite as 3 notas Do Infeliz: ");
			aluno.NotaFinal(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture),
							double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture),
							double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
		}
	}
}
