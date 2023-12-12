using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RonielDias.Models
{
    public class Pagamento
    {
        public int Id {get; set;}
        public DateTime DataLimite {get; set;}
        public double Valor {get; set;}
        public bool Pagou {get; set;}
    }
}