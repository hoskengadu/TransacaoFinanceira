using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransacaoFinanceira.Interface
{
    public interface IexecutarTransacaoFinanceira
    {
        void transferir(int correlation_id, uint conta_origem, uint conta_destino, decimal valor);
    }
}
