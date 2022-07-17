package az.repeat;

import java.util.ArrayList;
import java.util.Comparator;
import java.util.List;

public class Main {
    public static void main(String[] args) {
//        Person doc=new Doctor();
//        Developer dev=new Developer();
//        Person p1=new Person();
//
//        Person backDev=new BackEndDev();
//        System.out.println(backDev.getData());
        Person p1=new Person("Emil","Qoca",36);
        Person p2=new Person("Vusal","Abdullayev",30);
        Person p3=new Person("Valeh","Abdullayev",34);
        List<Person> people=new ArrayList<>();
        people.add(p1);
        people.add(p2);
        people.add(p3);



        people.sort(Comparator.comparingInt(Person::getAge));

        for (Person p:people){
            System.out.println(p.getData());
        }


    }
}
