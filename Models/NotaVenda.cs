using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RonielDias.Models
{
    public class NotaVenda
    {
        public int Id {get; set;}
        public DateTime Data {get; set;}
        public bool Tipo {get; set;}

        [ForeignKey("Cliente")]
        public int ClienteId {get; set;}
        public Cliente? Cliente {get; set;}

        [ForeignKey("Vendedor")]
        public int VendedorId {get; set;}
        public Vendedor? Vendedor {get; set;}

        [ForeignKey("Transportadora")]
        public int TransportadoraId {get; set;}
        public Transportadora? Transportadora {get; set;}

        [ForeignKey("Pagamento")]
        public int PagamentoId {get; set;} //rever se nao é Collection
        public Pagamento? Pagamento {get; set;}

        public virtual ICollection<Item>? Items {get;set;}
        public virtual ICollection<TipoPagamento>? TipoPagamentos {get;set;}
    }
}