package az.code.model;

public class Coffee {
    private static long counter = 1;
    private long id = counter++;

    @Override
    public String toString() {
        return this.getClass().getSimpleName() + ":" + this.id;
    }
}
