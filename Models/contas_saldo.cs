using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransacaoFinanceira.Models
{
    public class contas_saldo
    {
        public contas_saldo(uint conta, decimal valor)
        {
            this.conta = conta;
            this.saldo = valor;
        }
        public uint conta { get; set; }
        public decimal saldo { get; set; }
    }
}
