import java.util.Iterator;

public class MyList<T> implements Iterable<T>,List<T> {
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

    public void add(T item) {
        Node<T> newNode = new Node<>(item);
        if (this.headOfList != null) {
            Node<T> last = this.headOfList;
            while (last.next != null) {
                last = last.next;
            }
            last.next = newNode;
        } else {
            this.headOfList = newNode;
        }
    }

    public void add(T item, int index) {
        if (index < 0) {
            System.out.println("Index Out of range");
            return;
        }
        Node<T> newNode = new Node<>(item);
        Node<T> last = this.headOfList;
        while (index > 1) {
            last = last.next;
            if (checkIsNull(last)) {
                return;
            }
            index--;
        }
        newNode.next = last.next;
        last.next = newNode;
    }

    public T get(int index) {
        if (isEmpty())
            return null;
        Node<T> node = this.headOfList;
        node = loopNodes(index,node);
        if (checkIsNull(node) || index < 0) {
            return null;
        }
        return node.value;
    }


    public void remove(int index) {
        if (isEmpty())
            return;
        Node<T> node = this.headOfList;
        if (index == 0) {
            this.headOfList = node.next;
        }
        node = loopNodes(index,node);
        if (checkIsNull(node) && checkIsNull(node.next) || index < 0) {
            return;
        }
        if (node.next.next != null) {
            node.next = node.next.next;
        } else {
            node.next = null;
        }
    }

    public int find(T node) {
        if (isEmpty())
            return -1;
        Node<T> last = this.headOfList;
        int counter = 0;
        while (last.value != node && last.next != null) {
            last = last.next;
            counter++;
        }
        if (last.value == node) {
            return counter;
        }
        return -1;
    }

    private Node<T> loopNodes(int index, Node<T> node){
        while (index > 1) {
            node = node.next;
            index--;
        }
        return node;
    }
    private boolean checkIsNull(Node<T> last) {
        if (last == null) {
            System.out.println("Index out of range!");
            return true;
        }
        return false;
    }
    private boolean isEmpty(){
        if(this.headOfList==null){
            System.out.println("List is empty!");
            return true;
        }
        return false;
    }
}
