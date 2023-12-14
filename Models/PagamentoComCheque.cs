using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RonielDias.Models
{
    public class PagamentoComCheque : TipoDePagamento
    {   
        [Display(Name= "Numero do Banco")]
        public int Banco {get; set;}
        [Display(Name= "Nome do Banco")]
        public string? NomeDoBanco {get; set;}
    }
}