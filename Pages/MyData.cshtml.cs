using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_page.Models;

namespace Razor_page.Pages
{
    public class MyDataModel : PageModel
    {
        [BindProperty]
        public PersonInfo ? PersonInfo { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost() {

            return RedirectToPage("MyDataView", PersonInfo);
        }
    }
}