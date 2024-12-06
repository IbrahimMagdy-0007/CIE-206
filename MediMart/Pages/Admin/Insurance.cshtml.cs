using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MediMart.Pages.Admin
{
    public class InsuranceModel : PageModel
    {
        [BindProperty]
        public string ProviderName { get; set; }

        [BindProperty]
        public int CoveragePercentage { get; set; }

        public string SuccessMessage { get; set; }

        public void OnGet()
        {
            // Placeholder for loading insurance providers in the future
        }

        public IActionResult OnPostSaveProvider()
        {
            // Simulate saving the provider
            SuccessMessage = $"Insurance provider '{ProviderName}' with {CoveragePercentage}% coverage saved successfully.";

            // Redirect to the same page with a success message
            TempData["SuccessMessage"] = SuccessMessage;
            return RedirectToPage();
        }
    }
}
