public class Rectangle implements IShape{
    public Rectangle(){
        this.width  = RandomGenerator.generateRandomNumber(10 , 50);
        this.length  = RandomGenerator.generateRandomNumber(10 , 50);
    }

    private int width;
    private int length;

    @Override
    public String toString() {
        return "Rectangle{" +
                "width=" + width +
                ", length=" + length +
                '}';
    }
}
