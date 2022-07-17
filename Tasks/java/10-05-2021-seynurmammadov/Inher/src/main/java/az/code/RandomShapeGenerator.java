package az.code;

import java.util.Iterator;

public class RandomShapeGenerator implements Generator<IShape>, Iterable<IShape> {
    public IShape generateRandomShape(){
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
        return null;
    }
}
