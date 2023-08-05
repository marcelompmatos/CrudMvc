using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.IdentityModel.Tokens;

namespace CrudMvc.Models
{
    public class ProdutoViewModelIndex
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

    }
}
