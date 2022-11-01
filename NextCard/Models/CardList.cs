namespace NextCard.Models
{
    public class CardList
    {
        //public List<Card> cardList = new List<Card>() {
        //        { new Card() { CardNo = 1, Title = "Squat" }},
        //        { new Card() { CardNo = 2, Title = "Deadlift" }},
        //        { new Card() { CardNo = 3, Title = "Benchpress" }},
        //        { new Card() { CardNo = 4, Title = "Curl" }},
        //        { new Card() { CardNo = 5, Title = "Row" }}
        //    };

        private static List<Card>? _cards;
        public static List<Card> cardList
        {
            get
            {
                if (_cards == null)
                {
                    _cards = new List<Card>() {
                        { new Card() { CardNo = 1, Title = "Squat" } },
                        { new Card() { CardNo = 2, Title = "Deadlift" } },
                        { new Card() { CardNo = 3, Title = "Benchpress" } },
                        { new Card() { CardNo = 4, Title = "Curl" } },
                        { new Card() { CardNo = 5, Title = "Row" } }
                    };

                }
                return _cards;
            }
        }
    }
}
