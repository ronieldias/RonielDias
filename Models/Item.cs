using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RonielDias.Models
{
    public class Item
    {
        public int Id {get; set;}
        public double Preco {get; set;}
        public double Percentual {get; set;}
        public int Quantidade {get; set;}

        [ForeignKey("Produto")]
        public int ProdutoId {get; set;}
        public Produto? Produto {get; set;}
    }
}