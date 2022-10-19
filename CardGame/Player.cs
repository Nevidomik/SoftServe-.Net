using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cart_Game
{
    internal class Player
    {
        string name;
        List<Dictionary<string, int>> player_cards = new List<Dictionary<string, int>>();
        Dictionary<string, int> table_card = new Dictionary<string, int>();
        public string Name
        {
            get { return name; }
        }
        public List<Dictionary<string, int>> Player_cards
        {
            get { return player_cards; }
        }
        public Dictionary<string, int> Table_cards
        {
           get { return table_card;  }
        }
        public Player(string name)
        {
            this.name = name;
        }
        public void Add_card(Dictionary<string, int> card)
        {
            player_cards.Add(card);
        }
        public void Print_cards()
        {
            Console.WriteLine($"Player - {this.name}. Cards: ");
            foreach (var i in player_cards)
            {
                foreach (var card in i)
                Console.WriteLine($"{card.Key}");
            }
        }
        public void Remove_card(Dictionary<string, int> card)
        {
            player_cards.Remove(card);
        }
        public void On_table(Dictionary<string, int> card)
        {
            table_card = card;
        }
    }
}
