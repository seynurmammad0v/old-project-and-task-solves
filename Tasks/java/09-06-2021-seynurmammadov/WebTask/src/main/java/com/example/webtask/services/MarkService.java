package com.example.webtask.services;

import com.example.webtask.models.Mark;
import com.example.webtask.models.Pagination;
import com.example.webtask.models.dto.MarkStudentDTO;

import javax.servlet.http.HttpServletRequest;
import java.util.Optional;

public interface MarkService {
    Pagination<MarkStudentDTO> getAll(long student_id, HttpServletRequest request, Integer count, Integer page);

    Pagination<MarkStudentDTO> find(long student_id, String lessonName, HttpServletRequest request, Integer count, Integer page);

    Optional<MarkStudentDTO> getById(long student_id, long id);

    Mark save(long student_id, Mark mark);

    void delete(long student_id, long id);

}
