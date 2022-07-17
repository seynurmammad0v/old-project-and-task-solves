package com.example.CRUDapplication;

import com.example.CRUDapplication.models.Student;

import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import java.util.List;

public class CRUD {
    EntityManagerFactory emf;
    EntityManager em;

    public CRUD(EntityManagerFactory emf) {
        this.emf = emf;
    }

    public void mergeToDb(Student student) {
        em = emf.createEntityManager();
        em.getTransaction().begin();
        em.merge(student);
        em.getTransaction().commit();
        em.close();
    }

    public Student findById(long id) {
        em = emf.createEntityManager();
        Student student = em.find(Student.class, id);
        em.close();
        return student;
    }

    public List<Student> getAll() {
        em = emf.createEntityManager();
        List<Student> students = em.createNamedQuery("Student.getAll", Student.class).getResultList();
        em.close();
        return students;
    }

    public void delete(long id) {
        em = emf.createEntityManager();
        em.getTransaction().begin();
        em.remove(em.find(Student.class, id));
        em.getTransaction().commit();
        em.close();
    }
}
