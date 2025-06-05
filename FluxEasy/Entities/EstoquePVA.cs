namespace FluxEasy.Entities
{
    public class EstoquePVA
    {
        //Define a Entidade ProdutoAcabado no ASP.NET Core
        //Ele representa o produto final no sistema e seus atributos 
        public int Id { get; set; }
        public int IdProduto { get; set; }
        public string? Entrada { get; set; }
        public string ? Produtos { get; set; }
        public string ? Local { get; set; }
        public string? Lote { get; set; }
        public string ? Frascos { get; set; }
        public string ? Galoes { get; set; }
        public string? Bc10 { get; set; }
        public string? Bc50 { get; set; }
    }
}
