using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RonielDias.Models
{
    public class Vendedor
    {   
        [Display(Name= "Código")]
        public int Id {get; set;}
        [Display(Name= "Nome Do Vendedor")]
        public string? Nome {get; set;}
    }
}