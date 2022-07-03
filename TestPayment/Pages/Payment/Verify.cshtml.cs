using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TestPayment.Pages.Payment
{
    public class VerifyModel : PageModel
    {
        [BindProperty]
        public string ChecoutId { get; set; }
        [BindProperty]
        public string ResourcePath { get; set; }
        public IActionResult OnGet(string id, string resourcePath)
        {
            ChecoutId = id;
            ResourcePath = resourcePath;
            return Page();
        }
    }
}
