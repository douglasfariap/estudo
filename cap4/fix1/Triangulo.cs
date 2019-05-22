using System;
using System.Collections.Generic;
using System.Text;

namespace fix1 {
	class Triangulo {
		public double Largura;
		public double Altura;

		public double Area() {			
			return Altura*Largura;
		}
		public double Perimetro() {
			return 2*  (Altura + Largura);
		}
		public double Diagonal() {
			return Math.Sqrt(Largura * Largura + Altura * Altura);
		}
	}
}
