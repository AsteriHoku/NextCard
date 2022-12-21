namespace NextCard.Models;
public class CardList
{
    private static List<Card>? _cards;
    public static List<Card> cardList
    {
        get
        {
            if (_cards == null)
            {
                _cards = new List<Card>() {
                        { new Card() { CardNo = 1, Title = "Squat", Lorem = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."  } },
                        { new Card() { CardNo = 2, Title = "Deadlift", Lorem = "Lorem ipsum consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Dui sapien eget mi proin sed. Eu augue ut lectus arcu bibendum at varius vel pharetra. Netus et malesuada fames ac turpis egestas maecenas. Lorem ipsum dolor sit amet. Massa vitae tortor condimentum lacinia. Ut sem nulla pharetra diam sit amet nisl. Non blandit massa enim nec dui nunc mattis enim. Eleifend donec pretium vulputate sapien nec sagittis aliquam."  } },
                        { new Card() { CardNo = 3, Title = "Benchpress", Lorem = "Voxy fleck babblely vuvox, edmodo imeem. Spock oooj zapier shopify kno. Joyent wufoo etsy yoono. Imeem orkut zynga empressr chegg, eduvant zillow. Joost yuntaa gooru scribd jajah bubbli, klout akismet glogster. Vuvox nuvvo heekya wufoo ngmoco hipmunk, ning yuntaa joukuu chegg bitly, cotweet whrrl twitter koofers. Akismet zoosk heroku airbnb, mozy twitter zappos spock. Revver jibjab zoodles sococo orkut, insala tivo kazaa. Kno airbnb geni napster, skype."  } },
                        { new Card() { CardNo = 4, Title = "Curl", Lorem = "Bavaria ipsum dolor sit amet oba Haferl. Brodzeid nackata, Wiavui wos Schdeckalfisch. Um nix,vja bloß Biakriagal dahoam middn wo hi und glei wirds no fui lustiga Brotzeit. Wos i moan oiwei mei, koa iabaroi. Des muas ma hoid kenna Spuiratz gar nia need om auf’n Gipfe Brodzeid hinter’m Berg san a no Leit. Samma hod Trachtnhuat Foidweg wuid Biazelt? Nia need i moan scho aa i mechad dee Schwoanshaxn Kirwa, aasgem. Vui a bissal Servas obacht Spotzerl, wo hi Radler."  } },
                        { new Card() { CardNo = 5, Title = "Row", Lorem = "Doggo ipsum shooberino doggorino. Blop he made many woofs shoober boof pats. Super chub puggorino boof length boy long water shoob maximum borkdrive borking doggo, puggo puggorino wow very biscit ruff you are doing me the shock bork porgo, borkf h*ck wow such tempt thicc the neighborhood pupper. Mlem stop it fren much ruin diet adorable doggo boof porgo heckin angery woofer, tungg heckin angery woofer most angery pupper I have ever seen wow very biscit, pupperino." } }
                    };

            }
            return _cards;
        }
    }
}