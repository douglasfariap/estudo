using System;
using System.Collections.Generic;
using System.Text;

namespace exex4 {
	class Funcionario {
		public int id { get; set; }
		public string nome { get; set; }
		public double salario { get; private set; }

		public Funcionario(int id, string nome, double salario) {
			this.id = id;
			this.nome = nome;
			this.salario = salario;
		}

		public void increaseSalary(double percent) {
			salario = salario + salario * percent / 100;
		}
		
	}
}
