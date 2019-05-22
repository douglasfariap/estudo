using System;
using System.Collections.Generic;
using System.Text;

namespace fix2 {
	class Funcionario {
		public string Nome;
		public double SalarioBruto, Imposto;

		public double SalarioLiquido() {
			return SalarioBruto - Imposto;
		}
		public void AumentarSalario(double porcentagem) {
			SalarioBruto =SalarioBruto+ SalarioBruto * (porcentagem / 100);
		}

	}
}
