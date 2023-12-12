using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RonielDias.Models
{
    public class PagamentoComCheque : TipoPagamento
    {
        public int Banco {get; set;}
        public string? NomeDoBanco {get; set;}
    }
}