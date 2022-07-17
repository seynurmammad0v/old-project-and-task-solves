package code.az;

import java.util.ArrayList;
import java.util.List;

public class Manager extends Employee implements IEmployee {
    public String role;
    public ArrayList<Operator> subordinatesOperators;
    public String education;
    public String workExpirience;
    public Manager(String name, String surname, int salary) {
        super(name, surname, salary);
        subordinatesOperators = new ArrayList<>();
    }

    public void addSubordinate(Operator operator){
        subordinatesOperators.add(operator);
    }
    public void deleteSubordinate(Operator operator){
        subordinatesOperators.remove(operator);
    }

    @Override
    public int getMonthSalary() {
        return salary;
    }

    @Override
    public void onFire() {
        countOfFire++;
        System.out.println(countOfFire+". "+name+" adlı manager işdən çıxarıldı!");

    }

    @Override
    public void onHire() {
        countOfHire++;
        System.out.println(countOfHire+". "+name+" adlı manager işə qəbul edildi!");
    }

    @Override
    public String toString() {
        return "Adı: "+name+" Soyadı: "+surname+" Tutduqu vəzifə: Manager";
    }
}
