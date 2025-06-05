using System.ComponentModel.DataAnnotations;

namespace FluxEasy.Entities
{
    //Define a Entidade ProdutoAcabado no ASP.NET Core
    //Ele representa o produto final no sistema e seus atributos 
    public class ProdutoAcabado
    {
        [Key]
        public int ProdutoId { get; set; }

        [Required]
        public string ? Entrada { get; set; }

        public int Quantidade { get; set; }

        [Required]
        public string ? Lote { get; set; }

        public string ? Saida { get; set; }

        [Required]
        public string ? CodigoCola { get; set; }

        public string ? Embalagem { get; set; }

        public string ? Cliente { get; set; }
    }
}
