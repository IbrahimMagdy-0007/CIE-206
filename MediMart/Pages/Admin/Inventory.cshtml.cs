using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MediMart.Pages.Admin
{
    public class InventoryModel : PageModel
    {
        [BindProperty]
        public string ProductName { get; set; }

        [BindProperty]
        public int StockLevel { get; set; }

        [BindProperty]
        public string OrderProductName { get; set; }

        [BindProperty]
        public int OrderQuantity { get; set; }

        [BindProperty]
        public string Supplier { get; set; }

        public string OrderConfirmationMessage { get; set; }

        public void OnGet()
        {
            // Placeholder for loading inventory data
        }

        public IActionResult OnPostOrderProduct()
        {
            // Simulate placing an order
            OrderConfirmationMessage = $"Order placed for {OrderQuantity} units of '{OrderProductName}' from supplier '{Supplier}'.";

            // Redirect to the same page with a success message
            TempData["OrderSuccess"] = OrderConfirmationMessage;
            return RedirectToPage();
        }
    }
}
