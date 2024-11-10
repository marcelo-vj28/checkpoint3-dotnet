using System.Linq;
using Microsoft.AspNetCore.Mvc;
using CP3.MVC.Application.Dtos;
using CP3.MVC.MVC.Application.Interfaces;

namespace CP3.MVC.Controllers
{
    public class BarcoController : Controller
    {
        private readonly IBarcoApplicationService _barcoService;

        public BarcoController(IBarcoApplicationService barcoService)
        {
            _barcoService = barcoService;
        }

        public IActionResult Index()
        {
            var barcos = _barcoService.ObterTodos();
            return View(barcos);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(BarcoDto barco)
        {
            if (ModelState.IsValid)
            {
                _barcoService.Adicionar(barco);
                return RedirectToAction(nameof(Index));
            }
            return View(barco);
        }

        public IActionResult Edit(int id)
        {
            var barco = _barcoService.ObterPorId(id);
            if (barco == null)
            {
                return NotFound();
            }
            return View(barco);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(BarcoDto barco)
        {
            if (ModelState.IsValid)
            {
                _barcoService.Atualizar(barco);
                return RedirectToAction(nameof(Index));
            }
            return View(barco);
        }

        public IActionResult Details(int id)
        {
            var barco = _barcoService.ObterPorId(id);
            if (barco == null)
            {
                return NotFound();
            }
            return View(barco);
        }

        public IActionResult Delete(int id)
        {
            var barco = _barcoService.ObterPorId(id);
            if (barco == null)
            {
                return NotFound();
            }
            return View(barco);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _barcoService.Remover(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
