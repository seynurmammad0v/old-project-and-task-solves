public class Main {
    public static void main(String[] args) {
        for (IShape shape:new ShapeGenerator(5)){
            System.out.println(shape.toString());
        }
    }
}
