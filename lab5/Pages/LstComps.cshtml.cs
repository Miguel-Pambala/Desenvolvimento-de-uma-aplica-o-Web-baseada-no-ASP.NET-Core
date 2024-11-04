using lab5.Data;
using lab5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace lab5.Pages
{
    public class LstCompsModel : PageModel
    {
        private readonly DBCtrl _context;

        public LstCompsModel(DBCtrl context)
        {
            _context = context;
        }

        public List<GComp> Components { get; set; } = new List<GComp>();

        public void OnGet()
        {
            try
            {
                Components = _context.tComps.ToList(); // carregar os dados da tabela
            }
            catch (Exception ex)
            {
                // Log do erro ou exibir mensagem
                Console.WriteLine("Erro ao acessar o banco de dados: " + ex.Message);
            }
        }

    }
}
