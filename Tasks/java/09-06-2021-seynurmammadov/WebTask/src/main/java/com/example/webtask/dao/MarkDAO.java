package com.example.webtask.dao;

import com.example.webtask.models.Mark;

import java.util.List;
import java.util.Optional;

public interface MarkDAO {
    Optional<List<Mark>> getAll(long student_id);

    double getAvg(long student_id);

    List<Mark> find(long student_id, String lessonName);

    Optional<Mark> getById(long student_id, long id);

    Mark save(long student_id, Mark mark);

    void delete(long student_id, long id);
}
