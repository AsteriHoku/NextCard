using Microsoft.AspNetCore.Mvc;
using NextCard.Models;

namespace NextCard.Controllers
{
    public class HomeCareController : Controller
    {
        public IActionResult Index()
        {
            var cardList = new List<Card>() {
                { new Card() { CardNo = 1, Title = "Vacuum" }},
                { new Card() { CardNo = 2, Title = "Mop" }},
                { new Card() { CardNo = 3, Title = "Dishes" }},
                { new Card() { CardNo = 4, Title = "Laundry" }},
                { new Card() { CardNo = 5, Title = "Bathrooms" }}
            };

            //cardList.Add(new Card() { CardNo = 1, Title = "Vacuum" });

            return View();
        }

            

    }
}
