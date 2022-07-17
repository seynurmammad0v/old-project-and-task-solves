import java.util.Iterator;
import java.util.Queue;

public class MyQueue<T> implements Iterable<T>{
    private Node<T> startOfQueue;
    @Override
    public Iterator<T> iterator() {
        return new Iterator<T>() {
            Node<T> node = startOfQueue;
            boolean first = true;

            @Override
            public boolean hasNext() {
                return node.next != null ? true : false;
            }

            @Override
            public T next() {

                if (!first) {
                    node = node.next;
                } else first = false;
                return node.value;
            }
        };
    }

    public void push(T item) {
        Node<T> newNode = new Node<>(item);
        if (this.startOfQueue != null) {
            Node<T> last = this.startOfQueue;
            while (last.next != null) {
                last = last.next;
            }
            last.next = newNode;
        } else {
            this.startOfQueue = newNode;
        }
    }

    public T peek(){
        if (isEmpty())
            return null;
        Node<T> node = this.startOfQueue;
        this.startOfQueue=this.startOfQueue.next;
        return node.value;
    }

    private boolean isEmpty(){
        if(this.startOfQueue==null){
            System.out.println("List is empty!");
            return true;
        }
        return false;
    }

}
