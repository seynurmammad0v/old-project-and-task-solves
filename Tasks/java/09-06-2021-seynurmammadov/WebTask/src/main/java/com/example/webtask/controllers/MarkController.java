package com.example.webtask.controllers;

import com.example.webtask.exceptions.MarkNotFound;
import com.example.webtask.exceptions.StudentNotFound;
import com.example.webtask.models.Mark;
import com.example.webtask.models.Pagination;
import com.example.webtask.models.dto.MarkStudentDTO;
import com.example.webtask.services.MarkService;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import javax.servlet.http.HttpServletRequest;
import java.util.Optional;

@RestController
@RequestMapping("api/students/{student_id}/marks")
public class MarkController {

    MarkService markService;


    public MarkController(MarkService markService) {
        this.markService = markService;
    }

    @GetMapping
    public ResponseEntity<Pagination<MarkStudentDTO>> getAll(@PathVariable long student_id,
                                                             HttpServletRequest request,
                                                             @RequestParam(required = false) Integer count,
                                                             @RequestParam(required = false) Integer page) throws MarkNotFound {
        Pagination<MarkStudentDTO> marks = markService.getAll(student_id, request, count, page);
        if (marks != null) {
            return new ResponseEntity<>(marks, HttpStatus.OK);
        } else {
            throw new MarkNotFound();
        }
    }

    @GetMapping("/{id}")
    public ResponseEntity<MarkStudentDTO> getById(@PathVariable long student_id, @PathVariable long id) throws StudentNotFound, MarkNotFound {
        Optional<MarkStudentDTO> mark = markService.getById(student_id, id);
        if (mark.isPresent()) {
            return new ResponseEntity<>(mark.get(), HttpStatus.OK);
        } else {
            throw new MarkNotFound();
        }
    }

    @GetMapping("/find")
    public ResponseEntity<Pagination<MarkStudentDTO>> find(@PathVariable long student_id, @RequestParam String name, HttpServletRequest request, @RequestParam(required = false) Integer count, @RequestParam(required = false) Integer page) {
        return new ResponseEntity<>(markService.find(student_id, name, request, count, page), HttpStatus.OK);
    }

    @PostMapping
    public ResponseEntity<Mark> save(@PathVariable long student_id, @RequestBody Mark mark) {
        return new ResponseEntity<>(markService.save(student_id, mark), HttpStatus.OK);
    }

    @PutMapping("/{id}")
    public ResponseEntity<Mark> update(@PathVariable long student_id, @PathVariable long id, @RequestBody Mark mark) {
        mark.setId(id);
        return new ResponseEntity<>(markService.save(student_id, mark), HttpStatus.OK);
    }

    @DeleteMapping("/{id}")
    public void delete(@PathVariable long student_id, @PathVariable long id) {
        markService.delete(student_id, id);
    }
}
