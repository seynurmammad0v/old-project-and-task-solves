import java.util.Iterator;

public class ShapeGenerator implements Generator<IShape>, Iterable<IShape> {
    private int size;

    public ShapeGenerator(int size) {
        this.size = size;
    }
    class myIterator implements Iterator<IShape>{
        int size;

        public myIterator(int size) {
            this.size = size;
        }

        @Override
        public boolean hasNext() {
            return size>0;
        }

        @Override
        public IShape next() {
            size--;
            return generator();
        }
    }

    @Override
    public IShape generator() {
        int random = RandomGenerator.generateRandomNumber(1, 4);

        switch (random){
            case 1:
                return new Circle();
            case 2:
                return new Triangle();
            default:
                return new Rectangle();
        }
    }

    @Override
    public Iterator<IShape> iterator() {
        return new Iterator<IShape>() {
            @Override
            public boolean hasNext() {
                return size>0;
            }

            @Override
            public IShape next() {
                size--;
                return generator();
            }
        };
    }
}
