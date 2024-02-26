using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace U5_W1_D1.Models
{
    public class Pagamento
    {
        public int PagamentoID { get; set; }
        public int DipendenteID { get; set; }
        public DateTime PeriodoPagamento { get; set; }
        public decimal Ammontare { get; set; }
        public string TipoPagamento { get; set; }
    }
}