using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cart_Game
{
    internal class Game
    {
        List<Player> player_list = new List<Player>();
        public void Reg()
        {
            Console.WriteLine("Count players: ");
            int count = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Name: ");
                string? name = Console.ReadLine();
                Player obj = new Player(name);
                player_list.Add(obj);
            }

        }
        void Card_deal()
        {
            Card deck = new Card();
            deck.Create_deck();
            deck.Shuffle();

            while(deck.Deck.Count > 0)
            {
                for(int i = 0; i < player_list.Count; i++)
                {
                    player_list[i].Add_card(deck.Deck[0]);
                    deck.Remove_card(deck.Deck[0]);
                }
            }
        }
        public void Play()
        {
            Player win = null;
            Dictionary<string, int> tabl_card = new Dictionary<string, int>();
            Dictionary<string, int> win_card = new Dictionary<string, int>();
            Card_deal();
            while(player_list.Count > 1)
            {
                foreach (Player player in player_list)
                {
                    Move(player, tabl_card);
                    tabl_card = player.Table_cards;
                    if (win_card.Count == 0)
                    {
                        win_card = player.Table_cards;
                        win = player;
                    }
                    else
                    {
                        if (win_card.Last().Value < player.Table_cards.Last().Value)
                        {
                            win_card = player.Table_cards;
                            win = player;
                        }
                    }
                }
                Round(win);
            }
        }
        void Move(Player player, Dictionary<string, int> tabl_card)
        {
            int num;
            if (player.Player_cards.Count > 0)
            {
                Console.WriteLine($"\nChoose card {player.Name}");
                for (int i = 0; i < player.Player_cards.Count; i++)
                {
                    foreach (var card in player.Player_cards[i])
                    {
                        Console.WriteLine($"{i}) {card.Key}");
                    }
                }
                if (tabl_card.Count > 0)
                {
                    do
                    {
                        Console.Write("Card: ");
                        num = Convert.ToInt32(Console.ReadLine());
                    } while (tabl_card.Last().Key == player.Player_cards[num].Last().Key);
                }
                else
                {
                    Console.Write("Card: ");
                    num = Convert.ToInt32(Console.ReadLine());
                }
                player.On_table(player.Player_cards[num]);
            }
            else
            {
                player_list.Remove(player);
            }
           
        }
        void Round(Player won)
        {
            foreach(Player player in player_list)
            {
                if (player != won)
                {
                    player.Remove_card(player.Table_cards);
                    won.Add_card(player.Table_cards);
                }
            }
        }
    }
}
