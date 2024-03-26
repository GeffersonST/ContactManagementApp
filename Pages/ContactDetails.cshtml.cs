using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ContactManagementApp.Repositories;

namespace ContactManagementApp.Pages
{
    public class ContactDetailsModel : PageModel
    {
        private readonly IContactRepository _contactRepository;

        public ContactDetailsModel(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public Contact Contact { get; private set; }

        public IActionResult OnGet(int id)
        {
            Contact = _contactRepository.GetContactById(id);

            if (Contact == null)
            {
                return RedirectToPage("/Index");
            }

            return Page();
        }

        public IActionResult OnPostDelete(int id)
        {
            _contactRepository.DeleteContact(id);

            return RedirectToPage("/Index"); // Redirecionar para a página principal após a exclusão
        }
    }
}
