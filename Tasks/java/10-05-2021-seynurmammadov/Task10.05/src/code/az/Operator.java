package code.az;

import java.util.ArrayList;
import java.util.List;

public class Operator extends Employee implements IEmployee {
    public int deaskNumber;
    public ArrayList<String> languages;
    public ArrayList<String> duties;
    public Operator(String name, String surname, int salary, int deaskNumber) {
        super(name, surname, salary);
        this.deaskNumber = deaskNumber;
        languages = new ArrayList<>();
        duties = new ArrayList<>();
    }
    public void knownLanguages(){
        loopList(languages);
    }
    public void printDuties(){
        loopList(duties);
    }
    public void loopList(List<String> data){
        for (String item:
                data) {
            System.out.println(item);
        }
    }
    @Override
    public int getMonthSalary() {
        return salary;
    }

    @Override
    public void onFire() {
        countOfFire++;
        System.out.println(countOfFire+". "+name+" adlı operator işdən çıxarıldı!");
    }

    @Override
    public void onHire() {
        countOfHire++;
        System.out.println(countOfHire+". "+name+" adlı operator işə qəbul edildi!");
    }

    @Override
    public String toString() {
        return "Adı: "+name+" Soyadı: "+surname+" Tutduqu vəzifə: Operator";
    }
}
