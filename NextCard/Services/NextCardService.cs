using NextCard.Models;
using System.Collections.Generic;

namespace NextCard.Services
{
    public class NextCardService
    {
        public async Task<Card> RandomNext(Card card, List<Card> cardList)
        {
            var random = new Random();
            var nextCard = new Card()
            {
                CardNo = random.Next(1, cardList.Count() - card.CardNo)
            };

            return nextCard;
        }

        public async Task<Card> OrderedNext(Card card, List<Card> cardList)
        {
            if (card.CardNo == cardList.Count())
            {
                var firstCard = new Card()
                {
                    CardNo = 1
                };
                return firstCard;

            }
            var nextCard = new Card()
            {
                CardNo = card.CardNo++
            };

            return nextCard;
        }
    }
}
