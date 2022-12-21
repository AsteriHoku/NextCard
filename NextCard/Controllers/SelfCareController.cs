using Microsoft.AspNetCore.Mvc;
using NextCard.Models;

namespace NextCard.Controllers;
public class SelfCareController : Controller
{
    public IActionResult Index()
    {
        var cardList = new List<Card>() {
                { new Card() { CardNo = 1, Title = "Meditate" }},
                { new Card() { CardNo = 2, Title = "Brush & Floss Teeth" }},
                { new Card() { CardNo = 3, Title = "Yoga" }},
                { new Card() { CardNo = 4, Title = "Drink Water" }},
                { new Card() { CardNo = 5, Title = "Laugh" }}
            };

        return View();
    }
}
