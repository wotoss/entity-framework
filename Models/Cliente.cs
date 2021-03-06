using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace entity_framework.Models
{
    [Table("clientes")]
    public class Cliente
    {
        [Key]
        [Required]
        [Column("id")]
        public int Id { get; set; }
        
        [MaxLength(150)]
        [Column("nome")]
        [Required]
        public string Nome { get; set; }
        
        [Column("observacao", TypeName ="text")]
        [Required]
        public string Observacao { get; set; }

        [Column("endereco_id")]//esta é a propriedade
        public int EnderecoId { get; set; }
        
        [ForeignKey("EnderecoId")]//esta é a foreingKey
        public  Endereco Endereco { get; set;}
        
    }
}