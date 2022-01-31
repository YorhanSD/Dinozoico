using Dinozoico.Models;
using Dinozoico.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dinozoico.Controllers
{
    public class DinossauroController : Controller
    {
        private readonly IDinossauroRepositorio _dinossauroRepositorio;
        public DinossauroController(IDinossauroRepositorio dinossauroRepositorio)
        {
            _dinossauroRepositorio = dinossauroRepositorio;
        }
        public IActionResult Index()
        {
            List<DinossauroModel> dinossauro = _dinossauroRepositorio.BuscarTodos();
            return View(dinossauro);
        }
        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar()
        {
            return View();
        }

        public IActionResult DeletarConfirmacao()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(DinossauroModel dinossauro)
        {
        _dinossauroRepositorio.Adicionar(dinossauro);
        return RedirectToAction("Index");
        }
    }
}
