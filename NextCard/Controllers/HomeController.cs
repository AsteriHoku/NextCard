using Microsoft.AspNetCore.Mvc;
using NextCard.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace NextCard.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
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
                return View("Next", CardList.cardList.First());
            }

            if (cardNo == CardList.cardList.Count() + 1)
            {
                cardNo = 1;
            }
            
            Response.Cookies.Delete("cardNo");
            Response.Cookies.Append("cardNo", cardNo.ToString());

            return View("Next", CardList.cardList.FirstOrDefault(c => c.CardNo == cardNo));
        }

        //private List<Card> cardList = new List<Card>() {
        //        { new Card() { CardNo = 1, Title = "Squat" }},
        //        { new Card() { CardNo = 2, Title = "Deadlift" }},
        //        { new Card() { CardNo = 3, Title = "Benchpress" }},
        //        { new Card() { CardNo = 4, Title = "Curl" }},
        //        { new Card() { CardNo = 5, Title = "Row" }}
        //    };

        //public Card First()
        //{
        //    return View("Next", cardList.First());
        //}

        //public IActionResult Next(Card card)
        //{
        //    if (cardNo == 1 || cardNo == CardList.cardList.Count())
        //    {
        //        cardNo++;
        //        return View("Next", CardList.cardList.First());
        //    }
        //    cardNo++;

        //    return View("Next", CardList.cardList.FirstOrDefault(c => c.CardNo == cardNo));
        //}

        //public async Task<Card> RandomNext(Card card, List<Card> cardList)
        //{
        //    var random = new Random();
        //    var nextCard = new Card()
        //    {
        //        CardNo = random.Next(1, cardList.Count() - card.CardNo)
        //    };
        //    nextCard.Title = cardList.FirstOrDefault(c => c.CardNo == nextCard.CardNo).Title;

        //    return nextCard;
        //}

        //public async Task<Card> OrderedNext(Card card, List<Card> cardList)
        //{
        //    if (card.CardNo == cardList.Count())
        //    {
        //        var firstCard = new Card()
        //        {
        //            CardNo = 1
        //        };
        //        return firstCard;

        //    }
        //    var nextCard = new Card()
        //    {
        //        CardNo = card.CardNo++
        //    };

        //    return nextCard;
        //}

    }
}