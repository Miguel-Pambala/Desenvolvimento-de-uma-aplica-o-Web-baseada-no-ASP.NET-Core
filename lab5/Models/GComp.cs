using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lab5.Models // Certifique-se de que está usando o namespace "lab5.Models"
{
    [Table("tComps")] // Nome da tabela conforme o banco de dados
    public class GComp
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; } // Mapeia o campo "Id"

        [Required]
        [Column("CmpName")]
        [StringLength(100)]
        public string CmpName { get; set; } // Mapeia o campo "CmpName"

        [Column("Descr")]
        [StringLength(255)]
        public string? Descr { get; set; } // Mapeia o campo "Descr"

        [Required]
        [Column("Price", TypeName = "money")]
        public decimal Price { get; set; } // Mapeia o campo "Price"
    }
}
