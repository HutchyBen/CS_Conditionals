using System;
using System.Drawing;

namespace CinemaApp
{
    class CinemaApp
    {
        public struct Movie
        {
            public Movie(string name, int year, int age)
            {
                Name = name;
                Year = year;
                Age = age;
            }
            private string Name { get; }
            public int Age { get; }
            public int Year { get;  }
            public override string ToString()
            {
                return $"{Name}({Year})({Age})";
            }
        }
        
        static void Main()
        {
            List<Movie> movies = new List<Movie>();
            movies.Add(new Movie("The Rock", 1996, 15));
            movies.Add(new Movie("Face / Off", 1997, 18));
            movies.Add(new Movie("The Wicker Man", 2005, 12));
            movies.Add(new Movie("The Croods", 2012, 0));

            for (int i = 0; i < movies.Count; i++ )
            {
                Console.WriteLine($"{i+1}. {movies[i].ToString()}");
            }

            int index = -1;
            do
            {
                index = int.Parse(Console.ReadLine())-1;
            } while (index < 0 && index >= movies.Count);

            var selected = movies[index];
            if (selected.Age == 0)
            {
                goto Success;
            } 
            
            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());
            if (age >= selected.Age)
            {
                goto Success;
            }
            
            Console.WriteLine("Grow up.");
            return;
            
            Success:
            Console.WriteLine("You have selected " + selected.ToString() + ". Enjoy!");
            
            return;
        }
            
    }
}