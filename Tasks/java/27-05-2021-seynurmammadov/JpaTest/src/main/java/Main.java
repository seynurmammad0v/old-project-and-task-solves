import az.code.models.Car;

import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;

public class Main {
    public static void main(String[] args) {
        EntityManagerFactory emf = Persistence.createEntityManagerFactory("carPU");
        EntityManager em = emf.createEntityManager();
        Car c = em.find(Car.class, 1l);
        em.detach(c);
        em.createQuery("Select car from Car car");
        em.close();

    }
}
