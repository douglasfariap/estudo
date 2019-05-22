using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace cap5 {
	class Conta {
		private double _saldo;
		public int Numero { get; private set; }
		public string Titular { get; set; }

		public Conta() {
			_saldo = 0.0;
		}

		public Conta(int numero, string titular) :this() {
				Numero = numero;
				Titular = titular;					
		}

		public Conta(double saldo,int numero , string titular): this(numero, titular) {
			_saldo = saldo;			
		}

		public void Deposito(double quantia) {
			_saldo = _saldo + quantia;
			Console.WriteLine("Dados atualizados:\n"+ToString());
		}

		public void Saque(double quantia) {
			_saldo = _saldo - 5 - quantia;
			Console.WriteLine("Dados atualizados:\n" + ToString());

		}

		public override string ToString() {
			return "Dados da conta:\n" +
					Numero +
					", Titular: " +
					Titular +
					", Saldo: $ " +
					_saldo.ToString("F2",CultureInfo.InvariantCulture) ;			
		}
	}
}
