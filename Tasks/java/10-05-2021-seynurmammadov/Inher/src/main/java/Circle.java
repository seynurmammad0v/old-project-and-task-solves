public abstract class Circle implements IShape{
    public Circle() {
        System.out.println();
    }

    public static void main(String[] args) {
    }

}

class Outer extends Shape{
    public static void main(String[] args) {
        Outer out = new Outer();
        Outer.Inner inner = out.new Inner();
    }
}
