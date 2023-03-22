using System.IO.Pipelines;

namespace Biblioteca.Models
{
    public interface ILibroRepositorio
    {
        IEnumerable<Libro> TodosLosLibros { get; }
        IEnumerable<Libro> MasVendidos { get; }
        Libro? ObtenerLibroPorId(int libroId);
        IEnumerable<Libro> BuscarLibro(string consulta); 
    }
}
