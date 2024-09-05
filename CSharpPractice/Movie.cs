using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{

    internal class Movie {

        public string Name { get; set; }
        public int Year { get; set; }

        public float Rating { get; set; }

        public Movie(string name, int year, float rating)
        {
            this.Name = name;
            this.Year = year;
            this.Rating = rating;
        }

        public static List<Movie> GetDemoData()
        {

            List<Movie> movies = new List<Movie>
            {
                new Movie("Titanic", 1998, 4.5f),
                new Movie("The Fifth Element", 1997, 4.6f),
                new Movie("Terminator 2", 1991, 4.7f),
                new Movie("Avatar", 2009, 5),
                new Movie("Platoon", 1986, 4),
                new Movie("My Neighbor Totoro", 1988, 5),
                new Movie("The Fifth Element", 1997, 4.6f),
            };

            return movies;
        }

        public override string ToString()
        {
            return $"{this.Name} @{this.Year} @{this.Rating}";
        }

    }
}
