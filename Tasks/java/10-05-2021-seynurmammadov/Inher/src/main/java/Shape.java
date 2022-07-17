 public class Shape {
    class Inner{

    }
     public Shape() {
         System.out.println("Contructor default");
     }

     public Shape(String name) {
         System.out.println("Contructor Shape" + name);
     }

     protected final String draw(){
        return "Shape";
    }
}
