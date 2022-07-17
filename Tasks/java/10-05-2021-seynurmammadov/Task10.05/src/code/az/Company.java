package code.az;

import java.util.*;
import java.time.LocalDate;
import java.util.ArrayList;

public class Company {
    public String name;
    public String owner;
    public String contact;
    public String address;
    public LocalDate createdAt;
    ArrayList<IEmployee> employeesList;

    public Company(String name, String owner,String contact, String address) {
        this.name = name;
        this.owner = owner;
        this.address = address;
        this.contact = contact;
        this.createdAt = LocalDate.now();
        this.employeesList = new ArrayList<>();
    }
    private void add(int size,IEmployee employee){
        employeesList.add(size,employee);
        employee.onHire();
    }
    public void hire(IEmployee employee){
        if(employeesList.size()>0){
            Comparator<IEmployee> c = new EmployeeComparatorBySalary();
            int size= employeesList.size();
            //sorting
            while (size>0){
                size--;
                if (c.compare(employee,employeesList.get(size))==1){
                    add(size+1,employee);
                    return;
                }
            }
        }
        add(0,employee);
    }
    public void hireAll(ArrayList<IEmployee> employees){
        for (IEmployee employee:employees
             ) {
            hire(employee);
        }
    }
    public void fire(int count){
        if(employeesList.size()>=count){
            while (count>0){
                employeesList.get(0).onFire();
                employeesList.remove(0);
                count --;
            }
        }
        else {
            System.out.println("Bu qeder isci yoxdur!");
        }
    }
    public ArrayList<IEmployee> getTopSalaryStaff(int count){
        ArrayList<IEmployee> arrayList = new ArrayList<>();
        if(employeesList.size()>=count){
            for (int i=0;i<count;i++){
                arrayList.add(employeesList.get(i));
            }
        }
        return arrayList;
    }
    public ArrayList<IEmployee> getLowestSalaryStaff(int count){
        ArrayList<IEmployee> arrayList = new ArrayList<>();
        if(employeesList.size()>=count){
            for (int i=count-1;i>=0;i--){
                arrayList.add(employeesList.get(i));
            }
        }
        return arrayList;
    }

}
