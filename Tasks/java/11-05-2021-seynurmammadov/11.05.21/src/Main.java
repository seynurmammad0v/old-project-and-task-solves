import java.util.Queue;

public class Main {

    public static void main(String[] args) {

        MyStack<String> s = new MyStack<>();
        s.push("1");
        s.push("2");
        s.push("3");
        s.push("4");
        s.push("5");

        for (String a :s){
            System.out.println(a);
        }
       System.out.println(s.pop());
       /*  System.out.println("/////////////");
        for (String a :s){
            System.out.println(a);
        }*/

      /*  ArrayList<String> s = new ArrayList<>();
        s.add("seynur0");
        s.add("seynur1");
        s.add("seynur2");
        s.add("seynur3");
        s.add("seynur4");
        s.add("seynur5");
        s.add("seynur6");

        s.remove(3);
        for (String item : s) {
            System.out.println(item);
        }
        System.out.println(s.find("seynur4"));*/
    }}
