package com.example.webtask.dao;

import com.example.webtask.models.Mark;
import com.example.webtask.models.Student;
import com.example.webtask.repositories.StudentRepository;
import org.springframework.data.domain.Sort;
import org.springframework.stereotype.Component;

import java.util.List;
import java.util.Optional;

@Component
public class StudentDAODbImp implements StudentDAO {
    StudentRepository studentRepository;

    public StudentDAODbImp(StudentRepository studentRepository) {
        this.studentRepository = studentRepository;
    }

    @Override
    public List<Student> getAll() {
        return studentRepository.findAll(Sort.by("name"));
    }

    @Override
    public List<Student> find(String name, String surname) {
        return studentRepository.findAllByNameAndSurname(name, surname);
    }

    @Override
    public Optional<Student> getById(long id) {
        return Optional.of(studentRepository.getById(id));
    }

    @Override
    public Student save(Student student) {
        return studentRepository.save(student);
    }

    @Override
    public void delete(long id) {
        studentRepository.deleteById(id);
    }

    public List<Student> findAllByNameAndGrade(String name, int grade) {
        return studentRepository.findAllByNameAndGrade(name, grade);
    }

    @Override
    public List<Mark> findAllMarkByNameAndGrade(String name, int grade) {
        return studentRepository.findAllMarkByNameAndGrade(name, grade);
    }
}
