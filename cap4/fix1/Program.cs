using System;
using System.Globalization;

namespace fix1 {
	class Program {
		static void Main(string[] args) {
			Console.WriteLine("Entre a largura e altura do retângulo: ");
			Triangulo t1 = new Triangulo();
			t1.Largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
			t1.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			Console.WriteLine("Area= " + t1.Area().ToString("F2", CultureInfo.InvariantCulture));
			Console.WriteLine("Perinetro= " + t1.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
			Console.WriteLine("Diagonal= " + t1.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
		}
	}
}
