using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace TestPayment.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        [Required]
        public string CheckoutId { get; set; }
       
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (string.IsNullOrEmpty(CheckoutId))
            {
                return Page();
            }

            return Redirect($"Payment/Pay/{CheckoutId}");
        }
    }
}