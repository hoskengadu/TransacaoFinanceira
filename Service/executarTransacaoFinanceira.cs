using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransacaoFinanceira.Interface;
using TransacaoFinanceira.Models;

namespace TransacaoFinanceira.Service
{
    public class executarTransacaoFinanceira : acessoDados, IexecutarTransacaoFinanceira
    {
        public void transferir(int correlation_id, uint conta_origem, uint conta_destino, decimal valor)
        {
            contas_saldo conta_saldo_origem = getSaldo<contas_saldo>(conta_origem);
            if (conta_saldo_origem.saldo <= valor)
            {
                Console.WriteLine($"Transacao numero {correlation_id} foi cancelada por falta de saldo");
            }
            else
            {
                contas_saldo conta_saldo_destino = getSaldo<contas_saldo>(conta_destino);
                conta_saldo_origem.saldo -= valor;
                conta_saldo_destino.saldo += valor;
                Console.WriteLine($"Transacao numero {correlation_id} foi efetivada com sucesso! Novos saldos: Conta Origem:{conta_saldo_origem.saldo} | Conta Destino: {conta_saldo_destino.saldo}");
            }
        }
    }
}
