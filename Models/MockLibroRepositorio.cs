using System.IO.Pipelines;

namespace Biblioteca.Models
{
    public class MockLibroRepositorio :ILibroRepositorio
    {
        private readonly IAutorRepositorio _autorRepositorio = new MockAutorRepositorio();
        public IEnumerable<Libro> TodosLosLibros =>
            new List<Libro>
            {
                //hardcore
                new Libro {LibroId = 1, Nombre="Clean Code", Descripcion="Clean Code es una filosofía utilizada en el desarrollo de software cuyo objetivo es hacer más fácil la lectura y escritura de código. Se basa en la aplicación de técnicas sencillas con las que generamos un código claro e intuitivo que es más fácil de modificar.", Precio=300.90M, Url="https://elpythonista.com/analisis-clean-code", FotoLibro="https://m.media-amazon.com/images/I/41xShlnTZTL._SX376_BO1,204,203,200_.jpg", EsMasVendido= true, EnStock=true, AutorId=1, Autor= _autorRepositorio.TodosLosAutores.ToList()[0] },
                new Libro {LibroId= 2, Nombre="Code Complete", Descripcion="Libro de desarrollo de software, escrito por Steve McConnell y publicado en 1993 por Microsoft Press, que alienta a los desarrolladores a continuar más allá de la programación de código y reparación y el gran diseño por adelantado y los modelos en cascada.", Precio=270.81M, Url="https://www.cpiicyl.org/un-libro-sobre-construccion-de-software-code-complete/", FotoLibro="https://cf-assets2.tenlong.com.tw/products/images/000/127/011/medium/PG21401_BIG.jpg?1542262703", EsMasVendido=true, EnStock=true, AutorId=2, Autor=_autorRepositorio.TodosLosAutores.ToList()[1]}, 
                new Libro {LibroId=3, Nombre="The Mythical Man-Month", Descripcion="Ensayos de ingeniería de Software es un libro de administración de proyectos de Software de Fred Brooks, cuyo tema central intenta mostrar que «añadir recursos humanos a un proyecto retrasado lo hace demorarse aún más».", Precio=250.55M, Url="https://es.wikipedia.org/wiki/El_M%C3%ADtico_Hombre-Mes", FotoLibro="https://i.ebayimg.com/thumbs/images/g/SjcAAOSwcn5kFoM8/s-l300.jpg", EsMasVendido=false, EnStock=true, AutorId=3, Autor= _autorRepositorio.TodosLosAutores.ToList()[2]},
                new Libro {LibroId=4, Nombre="Clean Architecture", Descripcion="Guia para especialistas en la estructura de software", Precio=260.00M, Url="https://www.adictosaltrabajo.com/2018/01/23/revision-del-nuevo-libro-de-uncle-bob-clean-architecture/", FotoLibro="https://m.media-amazon.com/images/W/IMAGERENDERING_521856-T1/images/I/411csr6Nn0L.jpg", EsMasVendido=false, EnStock=true, AutorId=1, Autor= _autorRepositorio.TodosLosAutores.ToList()[0]}
                //new Libro {LibroId=4, Nombre="", Descripcion="", Precio=10.00M, Url="", FotoLibro="", EsMasVendido=false, EnStock=true, AutorId=3, Autor= _autorRepositorio.TodosLosAutores.ToList()[2]}
            };

        public IEnumerable<Libro> MasVendidos
        {
            get
            {
                return TodosLosLibros.Where(libroMasVendido); // devuelve libros mas vendidos
                
            }
        }

        public bool libroMasVendido(Libro li)
        {
            return li.EsMasVendido;
        }

        public Libro? ObtenerLibroPorId(int libroId) 
        {
            return TodosLosLibros.FirstOrDefault(li => li.LibroId == libroId);
        }
        public IEnumerable<Libro> BuscarLibro(string consulta)
        {
            throw new NotImplementedException();
        }
    }
}
