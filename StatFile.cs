using System;
using System.Collections.Generic;
using System.IO;

namespace GenPOTW
{
    public class StatFile
    {
        public List<Player> Players = new List<Player>();

        readonly StreamReader _file;

        public StatFile(string csv_path)
        {
            try
            {
                _file = new StreamReader( "PlayerStats.csv" );
                string line;
                while ((line = _file.ReadLine()) != null)
                {
                    if (line.Contains("Timestamp"))
                        continue;
                    string[] lines = line.Split(',');
                    Players.Add(new Player(lines[1], lines[2], lines[3], lines[4], lines[5], lines[6], lines[7], lines[8], lines[9], lines[10]));
                }
            }
            finally
            {
                if (_file != null)
                    _file.Close();
            }
        }
        
        public void PrintBest()
        {
            Player best = Players[0];
            Player secondBest = Players[0];

            foreach (Player p in Players)
            {
                p.calculateScore();
                if (p._potwscore > best._potwscore)
                {
                    secondBest = best;
                    best = p;
                }
                else if (p._potwscore > secondBest._potwscore)
                {
                    secondBest = p;
                }
            }

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("POTW is - " + best.getName() + " with a score of " + best._potwscore +
                              " and a point differential of " + (best._potwscore - secondBest._potwscore) + " over " +
                              secondBest.getName() + "!");
            Console.ReadKey();
        }
    }
}