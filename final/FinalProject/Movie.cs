public abstract class Movie{
    protected string _name;
    protected string _genre;
    protected string _director;
    protected float _rating;
    protected int _year;

    public string GetName(){
        return _name;
    }
    public int GetYear(){
        return _year;
    }
    public string GetDirector(){
        return _director;
    }
    public float GetRating(){
        return _rating;
    }
    public string GetGenre(){
        return _genre;
    }
}