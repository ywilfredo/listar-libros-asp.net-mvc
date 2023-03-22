namespace Biblioteca.Models
{
    public class Libro
    {
        public int LibroId { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string? Descripcion { get; set; }
        public decimal Precio { get; set; }
        public string? Url { get; set; }
        public string? FotoLibro { get; set; }
        public bool EsMasVendido { get; set; }
        public bool EnStock { get; set; }
        public int AutorId { get; set; }
        public Autor Autor { get; set; } = default!; 
    }
}
