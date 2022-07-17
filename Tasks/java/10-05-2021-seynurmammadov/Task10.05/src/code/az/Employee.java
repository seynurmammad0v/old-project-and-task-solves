package code.az;

public class Employee {
    public String name;
    public String surname;
    public int salary;
    public static int countOfHire=0;
    public static int countOfFire=0;
    public Employee(String name, String surname, int salary) {
        this.name = name;
        this.surname = surname;
        this.salary = salary;
    }
}
