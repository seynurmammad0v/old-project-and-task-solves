public class Circle implements IShape{
    private int radius;

    public Circle(){
        this.radius  = RandomGenerator.generateRandomNumber(10 , 50);
    }

    @Override
    public String toString() {
        return "Circle{" +
                "radius=" + radius +
                '}';
    }
}
