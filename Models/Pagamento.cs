using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RonielDias.Models
{
    public class Pagamento
    {
        [Display(Name= "Código")]
        public int Id {get; set;}
        [Display(Name= "Data Limite")]
        public DateTime DataLimite {get; set;}
        public double Valor {get; set;}
        public bool Pagou {get; set;}
    }
}