package com.example.webtask.controllers;

import com.example.webtask.exceptions.StudentNotFound;
import com.example.webtask.models.Mark;
import com.example.webtask.models.Pagination;
import com.example.webtask.models.Student;
import com.example.webtask.models.dto.MarkStudentDTO;
import com.example.webtask.models.dto.StudentMarkDTO;
import com.example.webtask.services.StudentService;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import javax.servlet.http.HttpServletRequest;
import java.util.Optional;

@RestController
@RequestMapping("api/students")
public class StudentController {
    StudentService studentService;

    public StudentController(StudentService studentService) {
        this.studentService = studentService;
    }

    @GetMapping
    public ResponseEntity<Pagination<StudentMarkDTO>> getAll(HttpServletRequest request,
                                                             @RequestParam(required = false) Integer count,
                                                             @RequestParam(required = false) Integer page) {
        return new ResponseEntity<>(studentService.getAll(request, count, page), HttpStatus.OK);
    }

    @GetMapping("/{id}")
    public ResponseEntity<StudentMarkDTO> getById(@PathVariable long id) throws StudentNotFound {
        Optional<StudentMarkDTO> student = studentService.getById(id);
        if (student.isPresent()) {
            return new ResponseEntity<>(student.get(), HttpStatus.OK);
        } else {
            throw new StudentNotFound();
        }
    }

    @GetMapping("/find")
    public ResponseEntity<Pagination<StudentMarkDTO>> find(@RequestParam String name,
                                                           @RequestParam String surname,
                                                           HttpServletRequest request,
                                                           @RequestParam(required = false) Integer count,
                                                           @RequestParam(required = false) Integer page) {
        return new ResponseEntity<>(studentService.find(name, surname, request, count, page), HttpStatus.OK);
    }

    @GetMapping("/findAllByNameAndGrade")
    public ResponseEntity<Pagination<StudentMarkDTO>> findAllByNameAndGrade(@RequestParam String name,
                                                                            @RequestParam Integer grade,
                                                                            HttpServletRequest request,
                                                                            @RequestParam(required = false) Integer count,
                                                                            @RequestParam(required = false) Integer page) {
        return new ResponseEntity<>(studentService.findAllByNameAndGrade(name, grade, request, count, page), HttpStatus.OK);
    }

    @GetMapping("/findAllMarkByNameAndGrade")
    public ResponseEntity<Pagination<MarkStudentDTO>> findAllMarkByNameAndGrade(@RequestParam String name,
                                                                                @RequestParam Integer grade,
                                                                                HttpServletRequest request,
                                                                                @RequestParam(required = false) Integer count,
                                                                                @RequestParam(required = false) Integer page) {
        return new ResponseEntity<>(studentService.findAllMarkByNameAndGrade(name, grade, request, count, page), HttpStatus.OK);
    }

    @PostMapping
    public ResponseEntity<Student> save(@RequestBody Student student) {
        return new ResponseEntity<>(studentService.save(student), HttpStatus.OK);
    }

    @PutMapping("/{id}")
    public ResponseEntity<Student> update(@PathVariable long id, @RequestBody Student student) {
        student.setId(id);
        return new ResponseEntity<>(studentService.save(student), HttpStatus.OK);
    }

    @DeleteMapping("/{id}")
    public void delete(@PathVariable long id) {
        studentService.delete(id);
    }

    @GetMapping("/gradeGreaterThan")
    public ResponseEntity<Pagination<StudentMarkDTO>> greaterThan(@RequestParam int grade,
                                                                  HttpServletRequest request,
                                                                  @RequestParam(required = false) Integer count,
                                                                  @RequestParam(required = false) Integer page) {
        return new ResponseEntity<>(studentService.gradeGreaterThan(grade, request, count, page), HttpStatus.OK);
    }

    @GetMapping("/top")
    public ResponseEntity<Pagination<StudentMarkDTO>> avg(HttpServletRequest request,
                                                          @RequestParam(required = false) Integer count,
                                                          @RequestParam(required = false) Integer page) {
        return new ResponseEntity<>(studentService.avgTopTen(request, count, page), HttpStatus.OK);
    }

    @GetMapping("/seventyPer")
    public ResponseEntity<Pagination<StudentMarkDTO>> seventyPer(HttpServletRequest request,
                                                                 @RequestParam(required = false) Integer count,
                                                                 @RequestParam(required = false) Integer page) {
        return new ResponseEntity<>(studentService.seventyPerGrade(request, count, page), HttpStatus.OK);
    }

}
