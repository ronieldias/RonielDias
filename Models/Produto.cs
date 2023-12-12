using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RonielDias.Models
{
    public class Produto
    {
        public int Id {get; set;}
        public string? Nome {get; set;}
        public string? Descricao {get; set;}
        public int Quantidade {get; set;}
        public double Preco {get; set;}

        [ForeignKey("Marca")]
        public int MarcaId {get; set;}
        public Marca? Marca {get; set;}
    }
}