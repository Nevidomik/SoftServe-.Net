using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cart_Game
{
    internal class Card
    {
        static List<string> type = new List<string>()
        {
            "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace"
        };
        static List<string> colour = new List<string>()
        {
            "red hearts", "red diamonds", "black spades", "black clubs"
        };

        List<Dictionary<string, int>> deck = new List<Dictionary<string, int>>();
        public List<Dictionary<string, int>> Deck
        {
            get { return deck; }
        }
        public void Create_deck()
        {
            for (int i = 0; i < colour.Count; i++)
            {
                for (int j = 0; j < type.Count; j++)
                {
                    Dictionary<string, int> card = new Dictionary<string, int>()
                    {
                        { $"{colour[i]} {type[j]}", j }
                    };
                    deck.Add(card);
                }
            }
        }
        public void Print_deck()
        {
            foreach(Dictionary<string, int> card in deck)
            {
                foreach (var i in card)
                    Console.WriteLine($"{i.Key}");
            }
 
        }
        public void Shuffle()
        {
            int i;
            var rand = new Random();
            List<Dictionary<string, int>> temp = new List<Dictionary<string, int>>();
            while(deck.Count > 0)
            {
                i = rand.Next(deck.Count);
                temp.Add(deck[i]);
                deck.Remove(deck[i]);
            }
            deck = temp;
        }
        public void Remove_card(Dictionary<string, int> card)
        {
            deck.Remove(card);
        }
    }
}
