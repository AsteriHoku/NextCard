using Microsoft.AspNetCore.Mvc;
using NextCard.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace NextCard.Controllers;
public class HomeController : Controller
{

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult NextCard()
    {
        return View();
    }

    public IActionResult About()
    {
        return View();
    }

    public IActionResult Next()
    {
        var cardNo = 1;

        if (Request.Cookies.Any(c => c.Key == "cardNo"))
        {
            cardNo = int.Parse(Request.Cookies["cardNo"]);
            cardNo++;
        }

        if (cardNo == 1)
        {
            cardNo++;
            Response.Cookies.Append("cardNo", cardNo.ToString());
            return View("Card", CardList.cardList.First());
        }

        if (cardNo == CardList.cardList.Count() + 1)
        {
            cardNo = 1;
        }

        Response.Cookies.Delete("cardNo");
        Response.Cookies.Append("cardNo", cardNo.ToString());

        return View("Card", CardList.cardList.FirstOrDefault(c => c.CardNo == cardNo));
    }

}