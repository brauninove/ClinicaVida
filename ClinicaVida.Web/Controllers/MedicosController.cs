using ClinicaVida.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaVida.Web.Controllers;

public class MedicosController : Controller
{
    public IActionResult Index(int? especialidadeId)
    {
        var medicos = ClinicaEmMemoria.ObterMedicos();

        if (especialidadeId.HasValue)
        {
            medicos = medicos
                .Where(m => m.EspecialidadeId == especialidadeId.Value)
                .ToList();
        }

        var resultado = medicos
            .OrderBy(m => m.Nome)
            .ToList();

        ViewBag.Especialidades = ClinicaEmMemoria.Especialidades;
        ViewBag.EspecialidadeSelecionada = especialidadeId;

        return View(resultado);
    }

    public IActionResult Details(int id)
    {
        var medico = ClinicaEmMemoria.ObterMedicos()
            .FirstOrDefault(m => m.Id == id);

        if (medico == null)
            return NotFound();

        return View(medico);
    }
}
