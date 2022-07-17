package com.example.webtask.repositories;

import com.example.webtask.models.Mark;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;

import java.util.List;

public interface MarkRepository extends JpaRepository<Mark, Long> {
    List<Mark> findAllByStudentId(long student_id);

    @Query("SELECT avg(m.grade) FROM Mark m WHERE m.student.id=:student_id")
    double markAvg(long student_id);

    List<Mark> findAllByStudentIdAndLessonName(long student_id, String lessonName);
}
