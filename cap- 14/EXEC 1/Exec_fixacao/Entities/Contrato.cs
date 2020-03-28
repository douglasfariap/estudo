using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_fixacao.Entities {
    class Contrato {
        public int numero { get; set; }
        public DateTime data { get; set; }
        public double valorContrato { get; set; }
        public List<Parcela> parcelas { get; set; }

        public Contrato(int numero, DateTime data, double valorContrato)
        {
            this.numero = numero;
            this.data = data;
            this.valorContrato = valorContrato;
            this.parcelas = new List<Parcela>();
        }
        public void addContrato( Parcela parcela)
        {
            parcelas.Add(parcela);
        }
    }
}
