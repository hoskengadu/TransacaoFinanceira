using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransacaoFinanceira.Models
{
    public class Transaction
    {
        public int CorrelationId { get; set; }
        public DateTime DateTime { get; set; }
        public uint ContaOrigem { get; set; }
        public uint ContaDestino { get; set; }
        public int Valor { get; set; }
    }
}
