package com.example.webtask.services;

import com.example.webtask.exceptions.StudentNotFound;
import com.example.webtask.models.Pagination;
import com.example.webtask.models.Student;
import com.example.webtask.models.dto.MarkStudentDTO;
import com.example.webtask.models.dto.StudentMarkDTO;

import javax.servlet.http.HttpServletRequest;
import java.util.Optional;

public interface StudentService {
    Pagination<StudentMarkDTO> getAll(HttpServletRequest request, Integer count, Integer page);

    Pagination<StudentMarkDTO> find(String name, String surname, HttpServletRequest request, Integer count, Integer page);

    Optional<StudentMarkDTO> getById(long id) throws StudentNotFound;

    Student save(Student student);

    void delete(long id);

    Pagination<StudentMarkDTO> avgTopTen(HttpServletRequest request, Integer count, Integer page);

    Pagination<StudentMarkDTO> gradeGreaterThan(int grade, HttpServletRequest request, Integer count, Integer page);

    Pagination<StudentMarkDTO> seventyPerGrade(HttpServletRequest request, Integer count, Integer page);

    Pagination<StudentMarkDTO> findAllByNameAndGrade(String name, int grade, HttpServletRequest request, Integer count, Integer page);

    Pagination<MarkStudentDTO> findAllMarkByNameAndGrade(String name, int grade, HttpServletRequest request, Integer count, Integer page);
}
