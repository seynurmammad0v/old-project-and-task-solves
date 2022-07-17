package com.example.webtask.dao;

import com.example.webtask.models.Mark;
import com.example.webtask.models.Student;
import org.springframework.stereotype.Component;

import java.time.LocalDate;
import java.util.List;
import java.util.Optional;
import java.util.stream.Collectors;
import java.util.stream.IntStream;

@Component
public class StudentDAOMemoryImpl implements StudentDAO {
    List<Student> studentList;

    public StudentDAOMemoryImpl() {
        this.studentList = IntStream.range(1, 100)
                .mapToObj(i ->
                        Student.builder()
                                .id(i)
                                .name("name" + i)
                                .surname("surname" + i)
                                .markList(
                                        IntStream.range(1, 8)
                                                .mapToObj(j ->
                                                        Mark.builder()
                                                                .id(j)
                                                                .creationDate(LocalDate.now())
                                                                .grade((int) (15 + Math.random() * 85))
                                                                .lessonName("lesson_name" + (int) (1 + Math.random() * 3))
                                                                .build())
                                                .collect(Collectors.toList()))
                                .build())
                .collect(Collectors.toList());
        for (Student stundent : studentList) {
            stundent.getMarkList().forEach(m -> m.setStudent(stundent));
        }
    }

    @Override
    public List<Student> getAll() {
        return studentList;
    }

    @Override
    public List<Student> find(String name, String surname) {
        return studentList.stream().filter(s -> s.getName().equals(name) && s.getSurname().equals(surname))
                .collect(Collectors.toList());
    }

    @Override
    public Optional<Student> getById(long id) {
        return studentList.stream().filter(s -> s.getId() == id).findFirst();
    }

    @Override
    public Student save(Student student) {
        Optional<Student> student1 = getById(student.getId());
        if (student1.isPresent()) {
            student1.get().setName(student.getName());
            student1.get().setSurname(student.getSurname());
            return student1.get();
        }
        student.setId(studentList.get(studentList.size() - 1).getId() + 1);
        studentList.add(student);
        return student;
    }

    @Override
    public void delete(long id) {
        Optional<Student> student = getById(id);
        student.ifPresent(value -> studentList.remove(value));
    }

    @Override
    public List<Student> findAllByNameAndGrade(String name, int grade) {
        List<Student> studentList = getAll();
        return studentList.stream()
                .filter(s -> s.getName().startsWith(name) &&
                        s.getMarkList().stream().anyMatch(m -> m.getGrade() > grade))
                .collect(Collectors.toList());
    }

    @Override
    public List<Mark> findAllMarkByNameAndGrade(String name, int grade) {
        List<Student> studentList = getAll();
        return studentList.stream()
                .filter(s -> s.getName().startsWith(name)).flatMap(m -> m.getMarkList().stream())
                .filter(m -> m.getGrade() > grade)
                .collect(Collectors.toList());
    }
}
