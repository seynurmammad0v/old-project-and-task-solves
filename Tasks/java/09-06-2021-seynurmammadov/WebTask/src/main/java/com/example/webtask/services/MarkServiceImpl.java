package com.example.webtask.services;

import com.example.webtask.dao.MarkDAO;
import com.example.webtask.models.Mark;
import com.example.webtask.models.Pagination;
import com.example.webtask.models.dto.MarkStudentDTO;
import com.example.webtask.models.dto.mapper.interfaces.MapStructMapper;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.beans.factory.annotation.Value;
import org.springframework.context.ApplicationContext;
import org.springframework.stereotype.Component;

import javax.servlet.http.HttpServletRequest;
import java.util.List;
import java.util.Optional;

@Component
public class MarkServiceImpl implements MarkService {
    MarkDAO markDAO;
    @Value("${mark.imp.name}")
    private String impMark;
    MapStructMapper mapStructMapper;

    public MarkServiceImpl(MapStructMapper mapStructMapper) {
        this.mapStructMapper = mapStructMapper;
    }

    @Autowired
    private void getStudentNMarkDAOs(ApplicationContext context) {
        this.markDAO = (MarkDAO) context.getBean(impMark);
    }

    @Override
    public Pagination<MarkStudentDTO> getAll(long student_id, HttpServletRequest request, Integer count, Integer page) {
        Optional<List<Mark>> list = markDAO.getAll(student_id);
        return list.map(marks -> new Pagination<>(request, count, page, mapStructMapper.marksToMarkStudentDTOs(marks))).orElse(null);
    }

    @Override
    public Pagination<MarkStudentDTO> find(long student_id, String lessonName, HttpServletRequest request, Integer count, Integer page) {
        return new Pagination<>(request, count, page, mapStructMapper.marksToMarkStudentDTOs(markDAO.find(student_id, lessonName)));
    }

    @Override
    public Optional<MarkStudentDTO> getById(long student_id, long id) {
        Optional<Mark> mark = markDAO.getById(student_id, id);
        return mark.map(value -> Optional.ofNullable(mapStructMapper.markToMarkStudentDTO(value))).orElse(null);
    }

    @Override
    public Mark save(long student_id, Mark mark) {
        return markDAO.save(student_id, mark);
    }

    @Override
    public void delete(long student_id, long id) {
        markDAO.delete(student_id, id);
    }


}
