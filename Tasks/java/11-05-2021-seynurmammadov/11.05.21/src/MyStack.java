import java.util.Iterator;

public class MyStack<T> implements Iterable<T> {
    private Node<T> headOfList;



    @Override
    public Iterator<T> iterator() {
        return new Iterator<T>() {
            Node<T> node = headOfList;
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
         if (this.headOfList != null) {
             newNode.next=headOfList;
            headOfList= newNode;
        } else {
            this.headOfList = newNode;
        }
    }

    public T pop( ){
        if (isEmpty())
            return null;
        Node<T> node = this.headOfList;
        this.headOfList=this.headOfList.next;
        return node.value;
    }

    private boolean isEmpty(){
        if(this.headOfList==null){
            System.out.println("List is empty!");
            return true;
        }
        return false;
    }
}
