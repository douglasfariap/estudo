using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_fixacao.Entities {
    class Parcela {
        public DateTime vencimento { get; set; }
        public double valorParcela { get; set; }

        public Parcela(DateTime vencimento, double valorParcela)
        {
            this.vencimento = vencimento;
            this.valorParcela = valorParcela;
        }
    }
}
