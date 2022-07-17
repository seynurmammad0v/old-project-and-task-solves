package com.example.webtask.services;

import com.example.webtask.dao.MarkDAO;
import com.example.webtask.dao.StudentDAO;
import com.example.webtask.exceptions.StudentNotFound;
import com.example.webtask.models.Pagination;
import com.example.webtask.models.Student;
import com.example.webtask.models.dto.MarkStudentDTO;
import com.example.webtask.models.dto.StudentMarkDTO;
import com.example.webtask.models.dto.mapper.interfaces.MapStructMapper;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.beans.factory.annotation.Value;
import org.springframework.context.ApplicationContext;
import org.springframework.stereotype.Component;

import javax.servlet.http.HttpServletRequest;
import java.util.*;
import java.util.stream.Collectors;

@Component
public class StudentServiceImpl implements StudentService {

    MapStructMapper mapStructMapper;
    MarkDAO markDAO;
    StudentDAO studentDAO;
    @Value("${student.imp.name}")
    private String impStudent;
    @Value("${mark.imp.name}")
    private String impMark;


    @Autowired
    private void getStudentNMarkDAOs(ApplicationContext context) {
        this.studentDAO = (StudentDAO) context.getBean(impStudent);
        this.markDAO = (MarkDAO) context.getBean(impMark);
    }

    public StudentServiceImpl(MapStructMapper mapStructMapper) {
        this.mapStructMapper = mapStructMapper;
    }

    @Override
    public Pagination<StudentMarkDTO> getAll(HttpServletRequest request, Integer count, Integer page) {
        return new Pagination<>(request, count, page, mapStructMapper.studentsToStudentMarkDTOs(studentDAO.getAll()));
    }

    @Override
    public Pagination<StudentMarkDTO> find(String name, String surname, HttpServletRequest request, Integer count, Integer page) {
        return new Pagination<>(request, count, page, mapStructMapper.studentsToStudentMarkDTOs(studentDAO.find(name, surname)));
    }

    @Override
    public Optional<StudentMarkDTO> getById(long id) throws StudentNotFound {
        Optional<Student> student = studentDAO.getById(id);
        return student.map(value -> Optional.ofNullable(mapStructMapper.studentToStudentMarkDTO(value))).orElse(null);
    }

    @Override
    public Student save(Student student) {
        return studentDAO.save(student);
    }

    @Override
    public void delete(long id) {
        studentDAO.delete(id);
    }

    @Override
    public Pagination<StudentMarkDTO> avgTopTen(HttpServletRequest request, Integer count, Integer page) {
        List<Student> sorted = studentDAO.getAll()
                .stream()
                .sorted(Comparator.comparingDouble(student -> (-1) * markDAO.getAvg(student.getId())))
                .collect(Collectors.toList());
        return new Pagination<>(request, count, page, mapStructMapper.studentsToStudentMarkDTOs(sorted));
    }

    @Override
    public Pagination<StudentMarkDTO> gradeGreaterThan(int grade, HttpServletRequest request, Integer count, Integer page) {
        List<Student> sorted = studentDAO.getAll().stream()
                .filter(s -> s.getMarkList().stream().anyMatch(m -> m.getGrade() > grade))
                .collect(Collectors.toList());
        return new Pagination<>(request, count, page, mapStructMapper.studentsToStudentMarkDTOs(sorted));

    }

    @Override
    public Pagination<StudentMarkDTO> seventyPerGrade(HttpServletRequest request, Integer count, Integer page) {
        List<Student> sorted = studentDAO.getAll().stream()
                .filter(s ->
                        ((int) s.getMarkList()
                                .stream()
                                .filter(m -> m.getGrade() > 49)
                                .count() * 100) / s.getMarkList().size() > 70)
                .collect(Collectors.toList());
        return new Pagination<>(request, count, page, mapStructMapper.studentsToStudentMarkDTOs(sorted));
    }

    @Override
    public Pagination<StudentMarkDTO> findAllByNameAndGrade(String name, int grade, HttpServletRequest request, Integer count, Integer page) {
        return new Pagination<>(request, count, page, mapStructMapper.studentsToStudentMarkDTOs(studentDAO.findAllByNameAndGrade(name, grade)));
    }

    @Override
    public Pagination<MarkStudentDTO> findAllMarkByNameAndGrade(String name, int grade, HttpServletRequest request, Integer count, Integer page) {
        return new Pagination<>(request, count, page, mapStructMapper.marksToMarkStudentDTOs(studentDAO.findAllMarkByNameAndGrade(name, grade)));
    }
}
