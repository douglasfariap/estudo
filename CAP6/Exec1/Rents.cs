﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exec1 {
	class Rents {
		public string nome { get; set; }
		public string email { get; set; }

		public Rents(string nome, string email) {
			this.nome = nome;
			this.email = email;
		}

		public override string ToString() {
			return nome + ", " + email;
		}
	} 
}
