namespace Biblioteca.Models
{
    public interface IAutorRepositorio
    {
        IEnumerable<Autor> TodosLosAutores { get; }
    }
}
