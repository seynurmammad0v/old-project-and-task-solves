public class SimpleGenerics<T> {
    public SimpleGenerics(T object) {
        this.object = object;
    }

    private T object;

    public T getObject() {
        return object;
    }
}
