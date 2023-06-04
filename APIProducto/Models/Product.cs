namespace APIProducto.Models
{
    public class Product
    {

        public int IdProduct { get; set; }
        public int CodigoBarra { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public string Categoria { get; set; }
        public float Precio { get; set; }
    }
}
