package com.example.webtask.dao;

import com.example.webtask.models.Mark;
import com.example.webtask.models.Student;

import java.util.List;
import java.util.Optional;

public interface StudentDAO {
    List<Student> getAll();

    List<Student> find(String name, String surname);

    Optional<Student> getById(long id);

    Student save(Student student);

    void delete(long id);

    List<Student> findAllByNameAndGrade(String name, int grade);

    List<Mark> findAllMarkByNameAndGrade(String name, int grade);
}
