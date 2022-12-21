using Microsoft.AspNetCore.Mvc;
using NextCard.Models;

namespace NextCard.Controllers;
public class ExercisesController : Controller
{
    public IActionResult Index()
    {
        var cardList = new List<Card>() {
                { new Card() { CardNo = 1, Title = "Squat" }},
                { new Card() { CardNo = 2, Title = "Deadlift" }},
                { new Card() { CardNo = 3, Title = "Benchpress" }},
                { new Card() { CardNo = 4, Title = "Curl" }},
                { new Card() { CardNo = 5, Title = "Row" }}
            };

        return View();
    }
}
