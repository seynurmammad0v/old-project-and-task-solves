package code.az;

import java.util.ArrayList;
import java.util.List;

public class TopManager extends Employee implements IEmployee {
    public String role;
    public ArrayList<Manager> subordinatesManagers;
    public ArrayList<String> skills;
    public String education;
    public String workExpirience;
    public TopManager(String name, String surname, int salary) {
        super(name, surname, salary);
        skills = new ArrayList<>();
        subordinatesManagers = new ArrayList<>();
    }
    public void addSubordinate(Manager manager){
        subordinatesManagers.add(manager);
    }
    public void deleteSubordinate(Manager manager){
        subordinatesManagers.remove(manager);
    }
    @Override
    public int getMonthSalary() {
        return salary;
    }

    @Override
    public void onFire() {
        countOfFire++;
        System.out.println(countOfFire+". "+name+" adlı top manager işdən çıxarıldı!");
    }

    @Override
    public void onHire() {
        countOfHire++;
        System.out.println(countOfHire+". "+name+" adlı top manager işə qəbul edildi!");
    }

    @Override
    public String toString() {
        return "Adı: "+name+" Soyadı: "+surname+" Tutduqu vəzifə: Top Manager";
    }
}
