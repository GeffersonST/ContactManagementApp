using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ContactManagementApp.Repositories;

namespace ContactManagementApp.Pages
{
    public class EditModel : PageModel
    {
        private readonly IContactRepository _contactRepository;

        public EditModel(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        [BindProperty]
        public Contact Contact { get; set; }

        public IActionResult OnGet(int id)
        {
            Contact = _contactRepository.GetContactById(id);

            if (Contact == null)
            {
                return RedirectToPage("/Index");
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _contactRepository.UpdateContact(Contact);

            return RedirectToPage("/Index");
        }
    }
}
