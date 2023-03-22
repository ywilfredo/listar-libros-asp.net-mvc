namespace Biblioteca.Models
{
    public class MockAutorRepositorio : IAutorRepositorio
    {

        //esta implementando solo el metodo que defini en el icategory
        public IEnumerable<Autor> TodosLosAutores =>
            new List<Autor>
            {
                //colocando el hardcore
                new Autor {AutorId=1, NombreAutor="Robert C. Martin", Descripcion="Ingeniero de software y autor estadounidense."},
                new Autor {AutorId=2, NombreAutor="Steve McConnell", Descripcion="Autor de muchos libros de texto de ingeniería de software, incluyendo Code Complete."},
                new Autor {AutorId=3, NombreAutor="Frederick Brooks", Descripcion="Ingeniero de software y científico de la computación, más conocido por dirigir el desarrollo del sistema operativo OS/360"}


            };
    }
}
