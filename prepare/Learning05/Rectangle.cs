public class Rectangle : Shape{
    double _length;
    double _width;

    public override double GetArea()
    {
        return _length * _width;
    }
}