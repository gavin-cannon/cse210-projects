public class MovieDatabase{
    private List<Movie> _movies = new List<Movie>();
    
    public List<Movie> GetMovies(){
        return _movies;
    }

    public void AddMovie(Movie movie){
        _movies.add(movie);
    }
    public List<Movie> SortByGenre(string genre){

    }
}