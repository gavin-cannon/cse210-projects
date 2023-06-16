public class Circle : Shape{
    double _radius;

    public override double GetArea(){
        return Math.PI * Math.Pow(_radius, 2); 
    }
}