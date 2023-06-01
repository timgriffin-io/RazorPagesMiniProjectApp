using DemoLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesMiniProject.Pages
{
    public class AddressesModel : PageModel
    {
        [BindProperty]
        public AddressModel Address { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if(ModelState.IsValid == false)
            {
                return Page();
            }

            return RedirectToPage("./Index");
        }
    }
}
