using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Razor_page.Models
{
    public class PersonInfo
    {
        public string ? Name { get; set; }
        [DisplayName("Last name")]
        public string ?LastName { get; set; }
        public string ?Surname { get; set; }
        public string ?Gender { get; set; }
        public List<string> ?Hobbies { get; set; }
        public string? City { get; set; }
        [DisplayName("Date of bithd")]
        public string? DateOfBithd { get; set; }
    }
}
