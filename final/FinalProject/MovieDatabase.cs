public class MovieDatabase{
    private List<Movie> _movies = new List<Movie>();
    private List<Movie2020s> _movies2020 = new List<Movie2020s>();
    
    public List<Movie> GetMovies(){
        return _movies;
    }

    public void AddMovie(Movie movie){
        _movies.Add(movie);
    }
    public void AddMovie2020(Movie2020s movie){
        _movies2020.Add(movie);
    }
    public List<Movie> SortByGenre(string genre){
        return _movies;
    }
    public MovieDatabase(Movie movie){
        _movies.Add(movie);
    }
    public MovieDatabase(){

    }
    public void Load(){
        string[] movieList = System.IO.File.ReadAllLines("movies.txt");
        foreach(string line in movieList){
        string[] movie = line.Split(",");
        string movieName = movie[0];
        int year = Int32.Parse(movie[1]);
        string director = movie[2];
        float rating = float.Parse(movie[3]);
        string genre = movie[4];

        if (year >= 1960 && year <= 1969){
            Movie1960s movie1960 = new Movie1960s(movieName, genre, director, rating, year);
            AddMovie(movie1960);
        }
        else if (year >=1970 && year <= 1979){
            Movie1970s movie1970 = new Movie1970s(movieName, genre, director, rating, year);
            AddMovie(movie1970);
        }
        else if (year >=1980 && year <= 1989){
            Movie1980s movie1980 = new Movie1980s(movieName, genre, director, rating, year);
            AddMovie(movie1980);
        }
        else if (year >=1990 && year <= 1999){
            Movie1990s movie1990 = new Movie1990s(movieName, genre, director, rating, year);
            AddMovie(movie1990);
        }
        else if (year >=2000 && year <= 2009){
            Movie2000s movie2000 = new Movie2000s(movieName, genre, director, rating, year);
            AddMovie(movie2000);
        }
        else if (year >=2010 && year <= 2019){
            Movie2010s movie2010 = new Movie2010s(movieName, genre, director, rating, year);
            AddMovie(movie2010);
        }
        else if (year >=2020 && year <= 2029){
            Movie2020s movie2020 = new Movie2020s(movieName, genre, director, rating, year);
            AddMovie(movie2020);
        }
        }
        

        
        
    
    }
}