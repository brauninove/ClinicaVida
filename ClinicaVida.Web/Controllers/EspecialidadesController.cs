using ClinicaVida.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaVida.Web.Controllers;

public class EspecialidadesController : Controller
{
    public IActionResult Index()
    {
        var contagem = ClinicaEmMemoria.Medicos
            .GroupBy(m => m.EspecialidadeId)
            .ToDictionary(g => g.Key, g => g.Count());

        ViewBag.Contagem = contagem;

        return View(ClinicaEmMemoria.Especialidades);
    }
}
