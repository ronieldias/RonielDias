using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System.Linq;
using System.Threading.Tasks;

namespace RonielDias.Models
{
    public class TipoPagamento 
    {   [Display(Name= "Código")]
        public int Id {get; set;}
        [Display(Name= "Nome do Cobrado")]
        public string? NomeDoCobrado {get; set;}
        [Display(Name= "Informações Adicionais")]
        public string? InformacoesAdicionais {get; set;}
    }
}