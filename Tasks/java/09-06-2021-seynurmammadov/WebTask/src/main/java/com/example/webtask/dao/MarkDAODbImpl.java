package com.example.webtask.dao;

import com.example.webtask.models.Mark;
import com.example.webtask.models.Student;
import com.example.webtask.repositories.MarkRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.beans.factory.annotation.Value;
import org.springframework.context.ApplicationContext;
import org.springframework.stereotype.Component;

import java.util.List;
import java.util.Optional;

@Component
public class MarkDAODbImpl implements MarkDAO {
    MarkRepository markRepository;
    StudentDAO studentDAO;

    public MarkDAODbImpl(MarkRepository markRepository) {
        this.markRepository = markRepository;
    }

    @Value("${student.imp.name}")
    private String imp;

    @Autowired
    private void getStudentDAO(ApplicationContext context) {
        this.studentDAO = (StudentDAO) context.getBean(imp);
    }


    @Override
    public Optional<List<Mark>> getAll(long student_id) {
        return Optional.ofNullable(markRepository.findAllByStudentId(student_id));
    }

    @Override
    public double getAvg(long student_id) {
        return markRepository.markAvg(student_id);
    }

    @Override
    public List<Mark> find(long student_id, String lessonName) {
        return markRepository.findAllByStudentIdAndLessonName(student_id, lessonName);
    }

    @Override
    public Optional<Mark> getById(long student_id, long id) {
        return Optional.of(markRepository.getById(id));
    }

    @Override
    public Mark save(long student_id, Mark mark) {
        Optional<Student> student = studentDAO.getById(student_id);
        if (student.isPresent()) {
            student.get().getMarkList().add(mark);
            studentDAO.save(student.get());
        }
        return mark;
    }

    @Override
    public void delete(long student_id, long id) {
        markRepository.deleteById(id);
    }
}
