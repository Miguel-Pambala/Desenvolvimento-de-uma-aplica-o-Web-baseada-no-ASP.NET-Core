using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using lab5.Data;
using lab5.Models;
using System.Threading.Tasks;

namespace lab5.Pages
{
    public class CreateCompModel : PageModel
    {
        private readonly DBCtrl _context;

        public CreateCompModel(DBCtrl context)
        {
            _context = context;
        }

        [BindProperty]
        public GComp NewComponent { get; set; } = new GComp();

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.tComps.Add(NewComponent);
            await _context.SaveChangesAsync();

            return RedirectToPage("LstComps");
        }
    }
}
