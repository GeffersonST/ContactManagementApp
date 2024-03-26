using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ContactManagementApp.Repositories; // Importe o namespace do repositório

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
    }
}
