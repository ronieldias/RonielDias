using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RonielDias.Models
{
    public class Produto
    {
        [Display(Name= "Código")]
        public int Id {get; set;}
        public string? Nome {get; set;}
        [Display(Name= "Descrição")]
        public string? Descricao {get; set;}
        public int Quantidade {get; set;}
        [Display(Name= "Preço")]
        public double Preco {get; set;}
        [Display(Name= "Código da Marca")]
        [ForeignKey("Marca")]
        public int MarcaId {get; set;}
        public Marca? Marca {get; set;}
    }
}