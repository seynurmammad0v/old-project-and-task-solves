package com.example.webtask.dao;

import com.example.webtask.models.Mark;
import com.example.webtask.models.Student;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.beans.factory.annotation.Value;
import org.springframework.context.ApplicationContext;
import org.springframework.stereotype.Component;

import java.util.Collection;
import java.util.List;
import java.util.Optional;
import java.util.stream.Collectors;

@Component
public class MarkDAOImpl implements MarkDAO {
    StudentDAO studentDAO;

    @Value("${student.imp.name}")
    private String imp;

    @Autowired
    private void getStudentDAO(ApplicationContext context) {
        this.studentDAO = (StudentDAO) context.getBean(imp);
    }

    @Override
    public Optional<List<Mark>> getAll(long student_id) {
        return studentDAO.getById(student_id).map(Student::getMarkList);
    }

    @Override
    public double getAvg(long student_id) {
        Optional<List<Mark>> markList = getAll(student_id);
        return markList.stream().flatMap(Collection::stream).mapToInt(Mark::getGrade).average().orElse(0);
    }

    @Override
    public List<Mark> find(long student_id, String lessonName) {
        Optional<List<Mark>> markList = getAll(student_id);
        return markList.stream().flatMap(Collection::stream).filter(m -> m.getLessonName().equals(lessonName)).collect(Collectors.toList());
    }

    @Override
    public Optional<Mark> getById(long student_id, long id) {
        Optional<List<Mark>> markList = getAll(student_id);
        return markList.stream().flatMap(Collection::stream).filter(m -> m.getId() == id).findFirst();
    }

    @Override
    public Mark save(long student_id, Mark mark) {
        Optional<Mark> db_mark = getById(student_id, mark.getId());
        if (db_mark.isPresent()) {
            db_mark.get().setLessonName(mark.getLessonName());
            db_mark.get().setGrade(mark.getGrade());
            db_mark.get().setCreationDate(mark.getCreationDate());
            return db_mark.get();
        }
        Optional<List<Mark>> markList = getAll(student_id);
        if (markList.isPresent()) {
            mark.setId(markList.get().get(markList.get().size() - 1).getId() + 1);
        } else {
            mark.setId(1);
        }
        markList.get().add(mark);
        return mark;
    }

    @Override
    public void delete(long student_id, long id) {
        Optional<Mark> mark = getById(student_id, id);
        Optional<List<Mark>> markList = getAll(student_id);
        mark.ifPresent(value -> markList.get().remove(value));
    }

}
