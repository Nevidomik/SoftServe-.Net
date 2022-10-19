using Microsoft.VisualBasic;
using System;
using System.Text;

namespace Cart_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.Reg();
            game.Play();
        }
    }
}
