using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace YourNamespace.Pages
{
    public class AddContactModel : PageModel
    {
        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string name, string contact, string email)
        {
            // Implemente a lógica para adicionar o novo contato ao banco de dados aqui
            // Lembre-se de validar os dados do formulário antes de adicionar o contato

            // Redirecione o usuário de volta para a página Index após adicionar o contato
            return RedirectToPage("/Index");
        }
    }
}
