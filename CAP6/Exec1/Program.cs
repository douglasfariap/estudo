using System;

namespace Exec1 {
	class Program {
		static void Main(string[] args) {
			Rents[] aluguel = new Rents[10];
			Console.WriteLine("Quantos quartos serão aludagos?");
			int n = int.Parse(Console.ReadLine());
			int quarto = 1;
			for (int i = 0; i < n; i++) {				
				Console.WriteLine("Aluguel #" + quarto);
				Console.Write("nome: ");
				string nome = Console.ReadLine();
				Console.Write("Email: ");
				string email = Console.ReadLine();
				Console.Write("Quarto: ");
				int q = int.Parse(Console.ReadLine());

				aluguel[q] = new Rents(nome, email);
				quarto++;
			}
			Console.WriteLine("Quartos ocupados:");
			/*for (int i =0; i < 10; i++) {
				if (aluguel[i] != null)
					Console.WriteLine(i +": "+aluguel[i].ToString());
			}*/

			Console.WriteLine("-------------------------------");

			foreach(Rents obj in aluguel) {
				Console.WriteLine(obj);
			}

		}
	}
}
