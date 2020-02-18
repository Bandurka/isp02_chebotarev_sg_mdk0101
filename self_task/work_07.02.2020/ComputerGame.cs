using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class ComputerGame
    {
        private string title { get; set; }
        private string developments { get; set; }
        private int yearOfReleaze { get; set; }
        private string genre { get; set; }

        public ComputerGame(string gameTitle, string gameDevelopments, int gameYearOfReleaze, string gameGenre)
        {
            title = gameTitle;
            developments = gameDevelopments;
            yearOfReleaze = gameYearOfReleaze;
            genre = gameGenre;
        }

        public override string ToString()
        {
            return "ComputerGame: " + title + " " + developments + " " + yearOfReleaze + " " + genre;
        }
    }
}
