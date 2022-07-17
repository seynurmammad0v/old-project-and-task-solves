public class Triangle implements IShape{
    public Triangle(){
        this.a  = RandomGenerator.generateRandomNumber(10 , 50);
        this.b  = RandomGenerator.generateRandomNumber(10 , 50);
        this.c  = RandomGenerator.generateRandomNumber(10 , 50);
    }

    private int a;
    private int b;
    private int c;

    @Override
    public String toString() {
        return "Triangle{" +
                "a=" + a +
                ", b=" + b +
                ", c=" + c +
                '}';
    }
}
