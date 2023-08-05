using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebCRUDMVCSQL.Models
{
    [Table("Tipo_Produto")]
    public class Tipo_Produto
    {
        [Key]
        [Column("Id_Tipo_Produto")]
        [Display(Name = "Id_Tipo_Produto")]
        public int Id_Tipo_Produto { get; set; }

        [Column("Ds_Tipo_Produto")]
        [Display(Name = "Ds_Tipo_Produto")]
        public string Ds_Tipo_Produto { get; set; }

      
    }
}
