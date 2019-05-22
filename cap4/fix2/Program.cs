using System;
using System.Globalization;

namespace fix2 {
	class Program {
		static void Main(string[] args) {
			Funcionario fun = new Funcionario();
			Console.Write("Nome: "); fun.Nome = Console.ReadLine();
			Console.Write("Salário Bruto: "); fun.SalarioBruto =double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
			Console.Write("Imposto: "); fun.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			Console.WriteLine("Funcionário: "+fun.Nome+", $ "+fun.SalarioLiquido().ToString("F2",CultureInfo.InvariantCulture));

			Console.Write("Digite a Porcentagem para aumentar o salário: ");
			fun.AumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
			Console.WriteLine("Dados Atualizados: "+ fun.Nome+", $ "+ fun.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture));
		}
	}
}
