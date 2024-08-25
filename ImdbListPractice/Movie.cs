using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImdbListPractice
{
    public class Movie
    {
        public string Name { get; set; }
        public double ImdbScore { get; set; }

        public Movie(string movieName, double imdbScore)
        {
            Name = movieName;
            ImdbScore = imdbScore;
        }


    }
}
