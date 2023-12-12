using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RonielDias.Models
{
    public class PagamentoComCartao : TipoPagamento   
    {
        public string? NumeroDoCartao {get; set;}
        public string? Bandeira {get; set;}
    }
}