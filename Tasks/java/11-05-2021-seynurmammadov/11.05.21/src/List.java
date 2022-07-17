import java.util.Iterator;

public interface List<T> {

        public void add(T item);

        public void add(T item, int index);

        public T get(int index);

        public void remove(int index);

        public int find(T node);

}
