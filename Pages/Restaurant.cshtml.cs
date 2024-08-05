using Microsoft.AspNetCore.Mvc.RazorPages;

namespace YourProjectNamespace.Pages
{
    public class RestaurantModel : PageModel
    {
        public string RestaurantName { get; private set; }
        public string Cuisine { get; private set; }
        public string Address { get; private set; }

        public void OnGet()
        {
            RestaurantName = "Кафе ABC";
            Cuisine = "Українська кухня";
            Address = "вул. Прикладна, 123, Київ";
        }
    }
}