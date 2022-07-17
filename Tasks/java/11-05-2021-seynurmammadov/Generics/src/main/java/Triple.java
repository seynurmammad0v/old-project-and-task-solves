public class Triple<K, V, T> extends Pair<K, V>{
    public final T third;
    public Triple(K first, V second, T third) {
        super(first, second);
        this.third = third;
    }
}
