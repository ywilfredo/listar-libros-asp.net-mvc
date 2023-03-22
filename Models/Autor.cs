using System.IO.Pipelines;

namespace Biblioteca.Models
{
    public class Autor
    {
        public int AutorId { get; set; }
        public string NombreAutor { get; set; } = string.Empty;
        public string? Descripcion { get; set; }
 
    }
}
