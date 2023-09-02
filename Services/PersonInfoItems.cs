namespace Razor_page.Services
{
    public class PersonInfoItems : IPersonInfoItems
    {
        public List<string> HobbiesList { get; private set; }
        public List<string> CitiesList { get; private set; }

        public PersonInfoItems()
        {
            HobbiesList = new List<string>() { "Dance", "Yoga", "Crafting", "Gaming" };
            CitiesList = new List<string>() { "Kyiv", "Chernivci", "Lviv", "Kharkiv", "Odesa" };
        }
    }
}
