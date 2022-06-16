using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var games = new List<string>() { "Fallout 4", "The Sims 4", "Stardew Vallley", "Tetris", "Monkey Island" };

            var sortedGames = games.OrderBy(x => x.Length);

            foreach(var game in sortedGames)
            {
                Console.WriteLine(game);
            }
        }
    }
}
