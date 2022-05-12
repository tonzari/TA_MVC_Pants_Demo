using Microsoft.AspNetCore.Mvc;
using TA_DEMO_MVC.Models;

namespace TA_DEMO_MVC.Controllers
{
    public class AboutController : Controller
    {
        public List<Pants> AllPants = new List<Pants>()
        {
            new Pants("Boonpie","XL","Black"),
            new Pants("Levi","M","Blue Denim"),
            new Pants("Applebottom", "XXXXL","Green"),
            new Pants("Boonpie","XL","Black"),
            new Pants("Levi","M","Blue Denim"),
            new Pants("Applebottom", "XXXXL","Green"),
            new Pants("Boonpie","XL","Black"),
            new Pants("Levi","M","Blue Denim"),
            new Pants("Applebottom", "XXXXL","Green"),
            new Pants("Boonpie","XL","Black"),
            new Pants("Levi","M","Blue Denim"),
            new Pants("Boonpie","XL","Black"),
            new Pants("Levi","M","Blue Denim"),
            new Pants("Applebottom", "XXXXL","Green"),
            new Pants("Applebottom", "XXXXL","Green")
        };

        // About/
        public IActionResult Index()
        {
            return View();
        }

        // About/Pants
        public IActionResult Pants()
        {
            return View(AllPants);
        }

        // About/PantsDetails
        public IActionResult PantsDetails()
        {
            Pants singlePair = AllPants[2];

            // An example of having to process the data before sending to the view
            if (singlePair.Brand == "Applebottom")
            {
                singlePair.Brand = "Hanky";
            }

            // modifying further, let's set a pants img url 
            singlePair.ImageUrl = "https://m.media-amazon.com/images/I/61DwBodGktL._AC_UX522_.jpg";

            return View(singlePair);
        }
    }
}
