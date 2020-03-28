using System;
using Exec_fixacao.Entities;

namespace Exec_fixacao.Servicos {
    class ServicoContrato {
        private IServicoPagamentoOnline _servicoPagamentoOnline;

        public ServicoContrato(IServicoPagamentoOnline servicoPagamentoOnline)
        {
            _servicoPagamentoOnline = servicoPagamentoOnline;
        }

        public void processarContrato(Contrato contrato, int meses){
            double pagamentoBasico = contrato.valorContrato / meses;

            for(int i = 1; i <= meses; i++)
            {
                DateTime dataParcela = contrato.data.AddMonths(i);
                double valoratt = pagamentoBasico + _servicoPagamentoOnline.juros(pagamentoBasico, i);
                double valorfinal = valoratt + _servicoPagamentoOnline.taxaPagamento(valoratt);
                contrato.addContrato(new Parcela(dataParcela,valorfinal));
            }
        }
    }
}
