using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace entity_framework.Models
{
    //esta classe pedido produtos será uma ligação de foreink com foreink
    [Table("pedidos_produtos")]
    public class PedidoProduto
    {
        [Key]
        [Required]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("pedido_id")]
        public int PedidoId { get; set; }//esta éa minha propriedade
        
        [ForeignKey("PedidoId")]
        public Pedido Pedido { get; set; }//este é minha foreink realcionamento.

        [Column("produto_id")]
        public int ProdutoId { get;  set; }

           
        [ForeignKey("ProdutoId")]   
        public Produto Produto { get; set; }

        
        [Column("valor")]
        [Required]
        public double Valor { get; set; }


        [Column("quantidade")]
        [Required]
        public int Quantidade { get; set; }
        
    }
}