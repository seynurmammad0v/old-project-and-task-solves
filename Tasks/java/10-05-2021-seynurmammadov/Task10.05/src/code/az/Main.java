package code.az;

import java.util.ArrayList;

public class Main {
    public static void main(String[] args) throws InterruptedException {

        // Consolu yuxari qaldirib baxin !!(data coxdur)
        Company c= new Company("SeynurMMC","Seynur Mammadov","+994559294860","Baku");
        ArrayList<IEmployee> employees= new ArrayList<>();
        for (int i=0; i<200;i++){
            Operator operator = new Operator("Kamran","Jabiev",RandomGenerator.generateRandomNumber(190,2000),RandomGenerator.generateRandomNumber(1,50));
            employees.add(operator);
            if(i<50){
                Manager manager = new Manager("Sunal","Jabiev",RandomGenerator.generateRandomNumber(190,6000));
                employees.add(manager);
                if(i<10){
                    TopManager topManager = new TopManager("Zahid","Qasimli",RandomGenerator.generateRandomNumber(190,10000));
                    employees.add(topManager);
                }

            }
        }
        c.hireAll(employees);

        c.fire(c.employeesList.size()/2);

        ArrayList<IEmployee> e=c.getLowestSalaryStaff(10);
        System.out.println("get Lowest Staff Salary ");
        for (IEmployee emp:e
             ) {
            System.out.println(emp.getMonthSalary());
        }
        e=c.getTopSalaryStaff(10);

        System.out.println("get Top Staff Salary ");
        for (IEmployee emp:e
        ) {
            System.out.println(emp.getMonthSalary());
        }
    }
}
