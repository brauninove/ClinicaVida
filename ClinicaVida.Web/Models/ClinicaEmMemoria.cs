namespace ClinicaVida.Web.Models;

public static class ClinicaEmMemoria
{
    public static List<Especialidade> Especialidades { get; } = new()
    {
        new Especialidade { Id = 1, Nome = "Cardiologia" },
        new Especialidade { Id = 2, Nome = "Dermatologia" },
        new Especialidade { Id = 3, Nome = "Pediatria" },
        new Especialidade { Id = 4, Nome = "Ortopedia" }
    };

    public static List<Medico> Medicos { get; } = new()
    {
        new Medico { Id = 1, Nome = "Ana Beatriz Costa", CRM = "12345-SP", EspecialidadeId = 1 },
        new Medico { Id = 2, Nome = "Bruno Almeida Santos", CRM = "23456-SP", EspecialidadeId = 2 },
        new Medico { Id = 3, Nome = "Carlos Eduardo Lima", CRM = "34567-SP", EspecialidadeId = 3 },
        new Medico { Id = 4, Nome = "Fernanda Oliveira", CRM = "45678-SP", EspecialidadeId = 4 },
        new Medico { Id = 5, Nome = "Juliana Martins", CRM = "56789-SP", EspecialidadeId = 1 },
        new Medico { Id = 6, Nome = "Ricardo Souza", CRM = "67890-SP", EspecialidadeId = 3 }
    };

    public static List<Medico> ObterMedicos()
    {
        return Medicos.Select(m =>
        {
            m.Especialidade = Especialidades
                .FirstOrDefault(e => e.Id == m.EspecialidadeId);
            return m;
        }).ToList();
    }
}
