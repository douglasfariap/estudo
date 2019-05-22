using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace fun3 {
	class Aluno {
		public string Nome;
		
		public void NotaFinal(double n1, double n2, double n3) {
			double notaf = n1 + n2 + n3;
			if (notaf >= 60.00) {
				Console.WriteLine("Nota Final: "+notaf.ToString("F2",CultureInfo.InvariantCulture));
				Console.WriteLine("Aprovado");
			} else {
				double remanescente = 60.00 - notaf;
				Console.WriteLine("Nota Final: " + notaf.ToString("F2", CultureInfo.InvariantCulture));
				Console.WriteLine("Reprovado");
				Console.WriteLine("Faltaram "+remanescente.ToString("F2", CultureInfo.InvariantCulture) +" Pontos");
				
			}
		}
	}
}
