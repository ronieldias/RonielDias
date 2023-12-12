using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RonielDias.Models
{
    public class Transportadora
    {   
        [Display(Name = "Códgo")]
        public int Id {get; set;}
        public string? Nome {get; set;}
    }
}