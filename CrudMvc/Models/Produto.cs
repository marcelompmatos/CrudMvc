using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudMvc.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        public int Id_Tipo_Produto { get; set; }

    
    }

  


}
