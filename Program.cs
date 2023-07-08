using System;
using System.Collections.Generic;
using System.IO;

namespace GenPOTW
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            StatFile sf = new StatFile("PlayerStats.csv");
            sf.Players = Validator.AntiCheatCheck(sf.Players);
            sf.PrintBest();
        }
    }
}