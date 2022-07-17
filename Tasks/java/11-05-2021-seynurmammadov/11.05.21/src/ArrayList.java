import java.util.Arrays;
import java.util.Iterator;

public class ArrayList<T> implements List<T>,Iterable<T>{

    private int size;
    private T[] array;
    private static int index=0;
    public ArrayList() {
        this.size = 10;
        this.array =(T[]) new Object[size];
    }
    @Override
    public Iterator<T> iterator() {
        return new Iterator<T>() {
            int i =0;
            boolean first = true;
            @Override
            public boolean hasNext() {
                return array[i+1]!=null?true:false;
            }

            @Override
            public T next() {
                if (!first) {
                    i++;
                } else first = false;
                return array[i];
            }
        };
    }
    public void checkLenghtAndResize(){
        if(index==array.length-1){
            size=array.length*2;
            T[] newArray = Arrays.copyOf(array, size);
            array=newArray;
        }
    }
    @Override
    public void add(T item) {
        checkLenghtAndResize();
        array[index]=item;
        index++;
    }

    @Override
    public void add(T item, int indexSend) {

        checkLenghtAndResize();
        for(int i=this.index; i>=indexSend; i--){
            array[i+1]=array[i];
        }
        array[indexSend]=item;
        index++;
    }


    @Override
    public T get(int indexSender) {
        if(indexSender>this.index){
            throw new IndexOutOfBoundsException("Ay yarmazz");
        }
        return array[indexSender];
    }

    @Override
    public void remove(int indexSend) {
        if(indexSend>this.index){
            throw new IndexOutOfBoundsException("Ay yarmazz");
        }
        checkLenghtAndResize();
        for(int i=indexSend; i<this.index; i++){
            array[i]=array[i+1];
        }
        array[index]=null;
        index--;
    }

    @Override
    public int find(T item) {
        for (int i=0;i<index;i++){
            if(array[i]==item){
                return i;
            }
        }
        return -1;
    }



}
