using System;
using System.Collections.Generic;
using System.IO;

namespace GenPOTW
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Player> players = new List<Player>();
            
            StreamReader file = null;
            string line;
            try
            {
                file = new StreamReader( "PlayerStats.csv" );
                while ((line = file.ReadLine()) != null)
                {
                    if (line.Contains("Timestamp"))
                        continue;
                    string[] lines = line.Split(',');
                    players.Add(new Player(lines[1], int.Parse(lines[2]),int.Parse(lines[3]),int.Parse(lines[4]),int.Parse(lines[5]),int.Parse(lines[6]),int.Parse(lines[7]),int.Parse(lines[8]),int.Parse(lines[9]), int.Parse(lines[10])));
                }
            }
            finally
            {
                if (file != null)
                    file.Close();
            }

            Player best = players[0];

            foreach (Player p in players)
            {
                p.calculateScore();
                if(p._potwscore > best._potwscore)
                    best = p;
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("POTW is - " + best.getName() + " with a score of " + best._potwscore);
            Console.ReadKey();
        }
    }
}