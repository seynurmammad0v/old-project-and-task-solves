package az.repeat;

public class Person {
    private String name;

    public Person(){}

    public Person(String name, String surname, int age) {
        this.name = name;
        this.surname = surname;
        this.age = age;
    }

    private String surname;

    public int getAge() {
        return age;
    }

    private int age;

    public String getData(){
        return name+"-"+age;
    }

}
