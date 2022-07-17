package com.example.webtask.repositories;

import com.example.webtask.models.Mark;
import com.example.webtask.models.Student;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;

import java.util.List;

public interface StudentRepository extends JpaRepository<Student, Long> {
    List<Student> findAllByNameAndSurname(String name, String surname);

    @Query("SELECT s FROM Student s  JOIN Mark mk ON s.id=mk.student.id WHERE s.name like :name% and mk.grade>:grade GROUP BY s.id")
    List<Student> findAllByNameAndGrade(String name, int grade);

    @Query("SELECT mk FROM  Mark mk JOIN Student s ON  s.id=mk.student.id WHERE s.name like :name% and mk.grade>:grade ")
    List<Mark> findAllMarkByNameAndGrade(String name, int grade);
}
