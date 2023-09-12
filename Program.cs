using System;
using System.Collections.Generic;
using TransacaoFinanceira.Interface;
using TransacaoFinanceira.Models;
using TransacaoFinanceira.Service;

namespace TransacaoFinanceira
{
    class Program
    {
        static void Main(string[] args)
        {
            IexecutarTransacaoFinanceira _iexecutarTransacaoFinanceira = new executarTransacaoFinanceira();

            List<Transaction> transactions = new List<Transaction>
            {
                new Transaction
                {
                    CorrelationId = 1,
                    DateTime = DateTime.Parse("09/09/2023 14:15:00"),
                    ContaOrigem = 938485762,
                    ContaDestino = 2147483649,
                    Valor = 150
                },
                new Transaction
                {
                    CorrelationId = 2,
                    DateTime = DateTime.Parse("09/09/2023 14:15:05"),
                    ContaOrigem = 2147483649,
                    ContaDestino = 210385733,
                    Valor = 149
                },
                new Transaction
                {
                    CorrelationId = 3,
                    DateTime = DateTime.Parse("09/09/2023 14:15:29"),
                    ContaOrigem = 347586970,
                    ContaDestino = 238596054,
                    Valor = 1100
                },
                new Transaction
                {
                    CorrelationId = 4,
                    DateTime = DateTime.Parse("09/09/2023 14:17:00"),
                    ContaOrigem = 675869708,
                    ContaDestino = 210385733,
                    Valor = 5300
                },
                new Transaction
                {
                    CorrelationId = 5,
                    DateTime = DateTime.Parse("09/09/2023 14:18:00"),
                    ContaOrigem = 238596054,
                    ContaDestino = 674038564,
                    Valor = 1489
                },
                new Transaction
                {
                    CorrelationId = 6,
                    DateTime = DateTime.Parse("09/09/2023 14:18:20"),
                    ContaOrigem = 573659065,
                    ContaDestino = 563856300,
                    Valor = 49
                },
                new Transaction
                {
                    CorrelationId = 7,
                    DateTime = DateTime.Parse("09/09/2023 14:19:00"),
                    ContaOrigem = 938485762,
                    ContaDestino = 2147483649,
                    Valor = 44
                },
                new Transaction
                {
                    CorrelationId = 8,
                    DateTime = DateTime.Parse("09/09/2023 14:19:01"),
                    ContaOrigem = 573659065,
                    ContaDestino = 675869708,
                    Valor = 150
                }
            };

            foreach (Transaction item in transactions)
            {
                _iexecutarTransacaoFinanceira.transferir(item.CorrelationId, item.ContaOrigem, item.ContaDestino, item.Valor);
            }
        }
    }
}
