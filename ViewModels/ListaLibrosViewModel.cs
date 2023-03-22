using Biblioteca.Models;

namespace Biblioteca.ViewModels
{
    public class ListaLibrosViewModel
    {
        public IEnumerable<Libro> Libros { get; }
        public string? AutorActual { get; }

        public ListaLibrosViewModel(IEnumerable<Libro> libros, string? autorActual)
        {
            Libros = libros;
            AutorActual = autorActual;
        }
    }
}
