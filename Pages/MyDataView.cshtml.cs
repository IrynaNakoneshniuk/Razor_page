using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_page.Models;

namespace Razor_page.Pages
{
    public class MyDataViewModel : PageModel
    {
        [BindProperty (SupportsGet =true)]
        public PersonInfo? PersonInfo { get; set; }
        public void OnGet()
        {
            var t = PersonInfo;
        }
    }
}
