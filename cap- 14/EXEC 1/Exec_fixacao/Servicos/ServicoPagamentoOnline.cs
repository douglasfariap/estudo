using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_fixacao.Servicos {
    interface IServicoPagamentoOnline {
        double taxaPagamento(double quantia);
        double juros(double quantia, int parcelas);

    }
}
