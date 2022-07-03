using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TestPayment.Pages.Payment
{
    public class PayModel : PageModel
    {
        [BindProperty]
        public string CheckoutId { get; set; }
        [BindProperty]
        public string ShopperResultUrl { get; set; }

        public PayModel(IConfiguration configuration)
        {
            ShopperResultUrl = $"{configuration.GetSection("App:SelfUrl").Value}/Payment/Verify";
        }

        public IActionResult OnGet(string id)
        {
            CheckoutId = id;
            return Page();
        }
    }
}
