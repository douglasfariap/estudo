using System;
using System.Globalization;

namespace cap5 {
	class Program {
		static void Main(string[] args) {
			
			Console.Write("Entre o número da conta: ");
			int conta = int.Parse(Console.ReadLine());
			Console.Write("Entre o titular da conta: ");
			string titular = Console.ReadLine();
			Console.Write("Haverá Depósito?: ");
			string dep = Console.ReadLine();

			if (dep == "n") {
				Conta c1 = new Conta(conta,titular);
				Console.WriteLine(c1);
				Console.Write("Entre com um valor para depósito: ");
				double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
				c1.Deposito(deposito);
				Console.Write("Entre com um valor para Saque: ");
				double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
				c1.Saque(saque);
			} else if(dep == "s") {
				Console.Write("Entre com o valor inicial: ");
				double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
				Conta c1 = new Conta(valor, conta, titular);
				Console.WriteLine(c1);
				Console.Write("Entre com um valor para depósito: ");
				double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
				c1.Deposito(deposito);
				Console.Write("Entre com um valor para Saque: ");
				double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
				c1.Saque(saque);

			} else {
				Console.WriteLine("Comando não reconhecido, Considerarei  que não haverá depósito!!!");
				Conta c1 = new Conta(conta, titular);
				Console.WriteLine(c1);
				Console.Write("Entre com um valor para depósito: ");
				double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
				c1.Deposito(deposito);
				Console.Write("Entre com um valor para Saque: ");
				double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
				c1.Saque(saque);
			}
			

			

		}

	}
}
