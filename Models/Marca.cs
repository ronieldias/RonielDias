using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RonielDias.Models
{
    public class Marca
    {
        [Display(Name= "Código")]
        public int Id {get; set;}
        public string? Nome {get; set;}
        [Display(Name= "Descrição")]        
        public string? Descricao {get; set;}
        public virtual ICollection<Produto>? Produtos {get;set;}
    }
}