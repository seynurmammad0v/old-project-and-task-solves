package az.code.utils;

import az.code.models.Person;
import org.hibernate.Session;
import org.hibernate.SessionFactory;
import org.hibernate.query.NativeQuery;
import org.hibernate.query.Query;

import java.util.List;

public class Main {
    public static void main(String[] args) {
        Session session = HibernateUtil.getSessionFactory().openSession();
        Query query = session.createQuery("Select p from Person p");
        List<Person> result = query.getResultList();
        result.stream().forEach(p -> System.out.println(p));

    }
}
