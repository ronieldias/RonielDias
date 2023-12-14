using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RonielDias.Models
{
    public class PagamentoComCartao : TipoDePagamento   
    {
        [Display(Name= "Número do Cartão")]
        public string? NumeroDoCartao {get; set;}
        [Display(Name= "Bandeira do Cartão")]
        public string? Bandeira {get; set;}
    }
}