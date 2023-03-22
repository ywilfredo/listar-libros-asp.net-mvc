using Microsoft.AspNetCore.Mvc;
using Biblioteca.Models;
using Biblioteca.ViewModels;

namespace Biblioteca.Controllers
{
    public class LibroController : Controller
    {
        private readonly ILibroRepositorio _libroRepositorio;
        private readonly IAutorRepositorio _autorRepositorio;

        public LibroController(ILibroRepositorio libroRepositorio, IAutorRepositorio autorRepositorio)
        {
            _libroRepositorio = libroRepositorio;
            _autorRepositorio = autorRepositorio;
        }
        public IActionResult Index()
        {
            return View();
        }

        // 
        public IActionResult Libros()
        {
          
            ListaLibrosViewModel listaLibrosViewModel = new ListaLibrosViewModel(_libroRepositorio.TodosLosLibros, "Robert C. Martin");
            return View(listaLibrosViewModel);
        }

    }
}
