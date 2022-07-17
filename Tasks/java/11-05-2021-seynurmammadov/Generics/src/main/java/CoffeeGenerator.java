import az.code.model.Coffee;
import az.code.model.Expresso;

import java.util.Iterator;

public class CoffeeGenerator implements Generator<Coffee>, Iterable<Coffee>{
    int size = 5;

    public CoffeeGenerator(int size) {
        this.size = size;
    }

    class MyIterator implements Iterator<Coffee>{
        int size;

        public MyIterator(int size) {
            this.size = size;
        }

        @Override
        public boolean hasNext() {
            return size > 0;
        }

        @Override
        public Coffee next() {
            size--;
            return CoffeeGenerator.this.generate();
        }
    }
    @Override
    public Coffee generate() {
        return new Expresso();
    }

    @Override
    public Iterator<Coffee> iterator() {
        return new MyIterator(this.size);
    }
}
