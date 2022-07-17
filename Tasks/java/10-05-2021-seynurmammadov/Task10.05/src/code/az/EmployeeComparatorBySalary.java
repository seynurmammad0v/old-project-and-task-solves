package code.az;

import java.util.Comparator;

public class EmployeeComparatorBySalary implements Comparator<IEmployee> {
    @Override
    public int compare(IEmployee o1, IEmployee o2) {
        return o1.getMonthSalary() > o2.getMonthSalary() ? -1 : 1;
    }
}