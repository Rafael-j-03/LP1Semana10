using System;
using System.Collections.Generic;

namespace SamePlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Player> setOfPlayers = new HashSet<Player>();

            Player player1 = new Player(PlayerType.Tank, "Ana");
            Player player2 = new Player(PlayerType.Slayer, "Paulo");
            Player player3 = new Player(PlayerType.Tank, "Ana");

            setOfPlayers.Add(player1);
            setOfPlayers.Add(player2);
            setOfPlayers.Add(player3);

            foreach (Player p in setOfPlayers)
            {
                Console.WriteLine($"{p.Name} is a {p.Type}");
            }
        }
    }
}