using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RonielDias.Models
{
    public class NotaVenda
    {
        [Display(Name= "Código")]
        public int Id {get; set;}
        [Display(Name= "Data da Venda")]
        public DateTime Data {get; set;}
        public bool Tipo {get; set;}

        [Display(Name= "Código do Cliente")]
        [ForeignKey("Cliente")]
        public int ClienteId {get; set;}
        public Cliente? Cliente {get; set;}

        [Display(Name= "Cógigo do Vendedor")]
        [ForeignKey("Vendedor")]
        public int VendedorId {get; set;}
        public Vendedor? Vendedor {get; set;}

        [Display(Name= "Código da Transportadora")]
        [ForeignKey("Transportadora")]
        public int TransportadoraId {get; set;}
        public Transportadora? Transportadora {get; set;}

        [Display(Name= "Código do Pagamento")]
        [ForeignKey("Pagamento")]
        public int PagamentoId {get; set;} //rever se nao é Collection
        public Pagamento? Pagamento {get; set;}

        [Display(Name= "Itens")]
        public virtual ICollection<Item>? Items {get;set;}
        [Display(Name= "Tipos de Pagamento")]
        public virtual ICollection<TipoPagamento>? TipoPagamentos {get;set;}
    }
}