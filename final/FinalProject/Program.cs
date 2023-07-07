using System;

class Program
{
    static void Main(string[] args)
    {
        MainMenu mainMenu = new MainMenu();
        MovieDatabase movieMothership = new MovieDatabase();
        DecadeMenu decadeMenu = new DecadeMenu();
        GenreMenu genreMenu = new GenreMenu();
        RatingMenu ratingMenu = new RatingMenu();
        movieMothership.Load();
        while (true)
        {
            string menuString = mainMenu.DisplayMenu();
            Console.WriteLine();
            Console.WriteLine(menuString);
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                Console.WriteLine(decadeMenu.DisplayMenu());
                decadeMenu.SetAnswer(Console.ReadLine());
                List<Movie> movies = movieMothership.GetMovies();
                int number = 1;
                if (decadeMenu.GetAnswer() == "1")
                {
                    Console.WriteLine();
                    Console.WriteLine("Here are some of my favorite movies from the 2020s so far!");
                    Console.WriteLine();
                    foreach(Movie movie in movies){
                        if (movie is Movie2020s){
                            Console.WriteLine($"{number}. {movie.GetName()}    \nYear: {movie.GetYear()}    \nGenre: {movie.GetGenre()}    \nDirector: {movie.GetDirector()}    \nMy rating: {movie.GetRating()}/5");
                            Console.WriteLine();
                            number += 1;
                        }
                    }
                }
                else if (decadeMenu.GetAnswer() == "2")
                {
                    Console.WriteLine();
                    Console.WriteLine("Here are some of my favorite movies from the 2010s!");
                    Console.WriteLine();
                    foreach(Movie movie in movies){
                        if (movie is Movie2010s){
                            Console.WriteLine($"{number}. {movie.GetName()}    \nYear: {movie.GetYear()}    \nGenre: {movie.GetGenre()}    \nDirector: {movie.GetDirector()}    \nMy rating: {movie.GetRating()}/5");
                            Console.WriteLine();
                            number += 1;
                        }
                    }
                }
                else if (decadeMenu.GetAnswer() == "3")
                {
                    Console.WriteLine();
                    Console.WriteLine("Here are some of my favorite movies from the 2000s!");
                    Console.WriteLine();
                   foreach(Movie movie in movies){
                        if (movie is Movie2000s){
                            Console.WriteLine($"{number}. {movie.GetName()}    \nYear: {movie.GetYear()}    \nGenre: {movie.GetGenre()}    \nDirector: {movie.GetDirector()}    \nMy rating: {movie.GetRating()}/5");
                            Console.WriteLine();
                            number += 1;
                        }
                    }
                }
                else if (decadeMenu.GetAnswer() == "4")
                {
                    Console.WriteLine();
                    Console.WriteLine("Here are some of my favorite movies from the 1990s!");
                    Console.WriteLine();
                   foreach(Movie movie in movies){
                        if (movie is Movie1990s){
                            Console.WriteLine($"{number}. {movie.GetName()}    \nYear: {movie.GetYear()}    \nGenre: {movie.GetGenre()}    \nDirector: {movie.GetDirector()}    \nMy rating: {movie.GetRating()}/5");
                            Console.WriteLine();
                            number += 1;
                        }
                    }
                }
                else if (decadeMenu.GetAnswer() == "5")
                {
                    Console.WriteLine();
                    Console.WriteLine("Here are some of my favorite movies from the 1980s!");
                    Console.WriteLine();
                   foreach(Movie movie in movies){
                        if (movie is Movie1980s){
                            Console.WriteLine($"{number}. {movie.GetName()}    \nYear: {movie.GetYear()}    \nGenre: {movie.GetGenre()}    \nDirector: {movie.GetDirector()}    \nMy rating: {movie.GetRating()}/5");
                            Console.WriteLine();
                            number += 1;
                        }
                    }
                }
                else if (decadeMenu.GetAnswer() == "6")
                {
                    Console.WriteLine();
                    Console.WriteLine("Here are some of my favorite movies from the 1970s!");
                    Console.WriteLine();
                   foreach(Movie movie in movies){
                        if (movie is Movie1970s){
                            Console.WriteLine($"{number}. {movie.GetName()}    \nYear: {movie.GetYear()}    \nGenre: {movie.GetGenre()}    \nDirector: {movie.GetDirector()}    \nMy rating: {movie.GetRating()}/5");
                            Console.WriteLine();
                            number += 1;
                        }
                    }
                }
                else if (decadeMenu.GetAnswer() == "7")
                {
                    Console.WriteLine();
                    Console.WriteLine("Here are some of my favorite movies from the 1960s!");
                    Console.WriteLine();
                   foreach(Movie movie in movies){
                        if (movie is Movie1960s){
                            Console.WriteLine($"{number}. {movie.GetName()}    \nYear: {movie.GetYear()}    \nGenre: {movie.GetGenre()}    \nDirector: {movie.GetDirector()}    \nMy rating: {movie.GetRating()}/5");
                            Console.WriteLine();
                            number += 1;
                        }
                    }
                }
            }
            else if (userInput == "2")
            {
                Console.WriteLine(genreMenu.DisplayMenu());
                genreMenu.SetAnswer(Console.ReadLine());
                List<Movie> movies = movieMothership.GetMovies();
                int number = 1;
                if (genreMenu.GetAnswer() == "1"){
                    Console.WriteLine();
                    Console.WriteLine("Here are all the RomCom movies:");
                    Console.WriteLine();
                    foreach(Movie movie in movies){
                        if (movie.GetGenre() == "RomCom"){
                            Console.WriteLine($"{number}. {movie.GetName()}    \nYear: {movie.GetYear()}    \nGenre: {movie.GetGenre()}    \nDirector: {movie.GetDirector()}    \nMy rating: {movie.GetRating()}/5");
                            Console.WriteLine();
                            number += 1;
                        }
                    }
                    
                }
                else if (genreMenu.GetAnswer() == "2"){
                    Console.WriteLine();
                    Console.WriteLine("Here are all the Family movies:");
                    Console.WriteLine();
                    foreach(Movie movie in movies){
                        if (movie.GetGenre() == "Family"){
                            Console.WriteLine($"{number}. {movie.GetName()}    \nYear: {movie.GetYear()}    \nGenre: {movie.GetGenre()}    \nDirector: {movie.GetDirector()}    \nMy rating: {movie.GetRating()}/5");
                            Console.WriteLine();
                            number += 1;
                        }
                    }
                }
                else if (genreMenu.GetAnswer() == "3"){
                    Console.WriteLine();
                    Console.WriteLine("Here are all the Musical movies:");
                    Console.WriteLine();
                    foreach(Movie movie in movies){
                        if (movie.GetGenre() == "Musical"){
                            Console.WriteLine($"{number}. {movie.GetName()}    \nYear: {movie.GetYear()}    \nGenre: {movie.GetGenre()}    \nDirector: {movie.GetDirector()}    \nMy rating: {movie.GetRating()}/5");
                            Console.WriteLine();
                            number += 1;
                        }
                    }
                }
                else if (genreMenu.GetAnswer() == "4"){
                    Console.WriteLine();
                    Console.WriteLine("Here are all the Comedy movies:");
                    Console.WriteLine();
                    foreach(Movie movie in movies){
                        if (movie.GetGenre() == "Comedy"){
                            Console.WriteLine($"{number}. {movie.GetName()}    \nYear: {movie.GetYear()}    \nGenre: {movie.GetGenre()}    \nDirector: {movie.GetDirector()}    \nMy rating: {movie.GetRating()}/5");
                            Console.WriteLine();
                            number += 1;
                        }
                    }
                }
                else if (genreMenu.GetAnswer() == "5"){
                    Console.WriteLine();
                    Console.WriteLine("Here are all the Thriller movies:");
                    Console.WriteLine();
                    foreach(Movie movie in movies){
                        if (movie.GetGenre() == "Thriller"){
                            Console.WriteLine($"{number}. {movie.GetName()}    \nYear: {movie.GetYear()}    \nGenre: {movie.GetGenre()}    \nDirector: {movie.GetDirector()}    \nMy rating: {movie.GetRating()}/5");
                            Console.WriteLine();
                            number += 1;
                        }
                    }
                }
                else if (genreMenu.GetAnswer() == "6"){
                    Console.WriteLine();
                    Console.WriteLine("Here are all the Mystery movies:");
                    Console.WriteLine();
                    foreach(Movie movie in movies){
                        if (movie.GetGenre() == "Mystery"){
                            Console.WriteLine($"{number}. {movie.GetName()}    \nYear: {movie.GetYear()}    \nGenre: {movie.GetGenre()}    \nDirector: {movie.GetDirector()}    \nMy rating: {movie.GetRating()}/5");
                            Console.WriteLine();
                            number += 1;
                        }
                    }
                }
                else if (genreMenu.GetAnswer() == "7"){
                    Console.WriteLine();
                    Console.WriteLine("Here are all the Documentary movies:");
                    Console.WriteLine();
                    foreach(Movie movie in movies){
                        if (movie.GetGenre() == "Documentary"){
                            Console.WriteLine($"{number}. {movie.GetName()}    \nYear: {movie.GetYear()}    \nGenre: {movie.GetGenre()}    \nDirector: {movie.GetDirector()}    \nMy rating: {movie.GetRating()}/5");
                            Console.WriteLine();
                            number += 1;
                        }
                    }
                }
                else if (genreMenu.GetAnswer() == "8"){
                    Console.WriteLine();
                    Console.WriteLine("Here are all the Adventure movies:");
                    Console.WriteLine();
                    foreach(Movie movie in movies){
                        if (movie.GetGenre() == "Adventure"){
                            Console.WriteLine($"{number}. {movie.GetName()}    \nYear: {movie.GetYear()}    \nGenre: {movie.GetGenre()}    \nDirector: {movie.GetDirector()}    \nMy rating: {movie.GetRating()}/5");
                            Console.WriteLine();
                            number += 1;
                        }
                    }
                }
                else if (genreMenu.GetAnswer() == "9"){
                    Console.WriteLine();
                    Console.WriteLine("Here are all the Drama movies:");
                    Console.WriteLine();
                    foreach(Movie movie in movies){
                        if (movie.GetGenre() == "Drama"){
                            Console.WriteLine($"{number}. {movie.GetName()}    \nYear: {movie.GetYear()}    \nGenre: {movie.GetGenre()}    \nDirector: {movie.GetDirector()}    \nMy rating: {movie.GetRating()}/5");
                            Console.WriteLine();
                            number += 1;
                        }
                    }
                }
                else if (genreMenu.GetAnswer() == "10"){
                    Console.WriteLine();
                    Console.WriteLine("Here are all the Fantasy movies:");
                    Console.WriteLine();
                    foreach(Movie movie in movies){
                        if (movie.GetGenre() == "Fantasy"){
                            Console.WriteLine($"{number}. {movie.GetName()}    \nYear: {movie.GetYear()}    \nGenre: {movie.GetGenre()}    \nDirector: {movie.GetDirector()}    \nMy rating: {movie.GetRating()}/5");
                            Console.WriteLine();
                            number += 1;
                        }
                    }
                }
            }
            else if (userInput == "3")
            {
                Console.WriteLine(ratingMenu.DisplayMenu());
                ratingMenu.SetAnswer(Console.ReadLine());
                List<Movie> movies = movieMothership.GetMovies();
                int number = 1;
                if(ratingMenu.GetAnswer() == "1"){
                    movies.Sort((x, y) => y.GetRating().CompareTo(x.GetRating()));
                    foreach(Movie movie in movies){
                        Console.WriteLine($"{number}. {movie.GetName()}    \nYear: {movie.GetYear()}    \nGenre: {movie.GetGenre()}    \nDirector: {movie.GetDirector()}    \nMy rating: {movie.GetRating()}/5");
                        number += 1;
                    }
                }
                else if(ratingMenu.GetAnswer() == "2"){
                    movies.Sort((x, y) => x.GetRating().CompareTo(y.GetRating()));
                    foreach(Movie movie in movies){
                        Console.WriteLine($"{number}. {movie.GetName()}    \nYear: {movie.GetYear()}    \nGenre: {movie.GetGenre()}    \nDirector: {movie.GetDirector()}    \nMy rating: {movie.GetRating()}/5");
                        number += 1;
                }
                }
                
            }
            else if (userInput == "4")
            {
                Console.Write("Quitting");
                for (int i = 3; i> 0; i--){
                Console.Write(".");
                Thread.Sleep(1000);
            }
                break;
            }
        }
    }
}