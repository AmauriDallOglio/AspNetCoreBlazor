using AspNetCoreBlazor.Exemplos.Nucleo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace AspNetCoreBlazor.Exemplos.Pages.Grid
{
    public class GridStickyModel : PageModel
    {
        public List<GridStickyDto> Registros { get; private set; } = new List<GridStickyDto>();

        public void OnGet()
        {
            // Gerar 20 usuários para exibir na tabela
            for (int i = 1; i <= 20; i++)
            {
                Registros.Add(new GridStickyDto
                {
                    Nome = $"Usuário {i}",
                    Codigo = $"COD{i:000}",
                    Email = $"usuario{i}@exemplo.com",
                    DataNascimento = new DateTime(1990, 1, 1).AddDays(i * 30),
                    DataCadastro = DateTime.Now.AddDays(-i),
                    Ativo = i % 2 == 0,
                    Cpf = $"000.000.000-{i:00}"
                });
            }
        }
    }
}