package com.example.webtask.models.dto.mapper;

import com.example.webtask.models.Mark;
import com.example.webtask.models.Student;
import com.example.webtask.models.dto.MarkDTO;
import com.example.webtask.models.dto.MarkStudentDTO;
import com.example.webtask.models.dto.StudentDTO;
import com.example.webtask.models.dto.StudentMarkDTO;
import com.example.webtask.models.dto.mapper.interfaces.MapStructMapper;
import org.springframework.stereotype.Component;

import java.util.ArrayList;
import java.util.List;
import java.util.stream.Collectors;

@Component
public class MapStructMapperImpl implements MapStructMapper {
    @Override
    public StudentMarkDTO studentToStudentMarkDTO(Student student) {
        if (student == null) {
            return null;
        }

        StudentMarkDTO studentMarkDTO = new StudentMarkDTO();
        studentMarkDTO.setId(student.getId());
        studentMarkDTO.setName(student.getName());
        studentMarkDTO.setSurname(student.getSurname());
        studentMarkDTO.setMarkList(marksToMarksDTOs(student.getMarkList()));
        return studentMarkDTO;
    }

    @Override
    public List<StudentMarkDTO> studentsToStudentMarkDTOs(List<Student> students) {
        return students.stream().map(this::studentToStudentMarkDTO).collect(Collectors.toList());
    }

    @Override
    public MarkStudentDTO markToMarkStudentDTO(Mark mark) {
        if (mark == null) {
            return null;
        }

        MarkStudentDTO markStudentDTO = new MarkStudentDTO();
        markStudentDTO.setId(mark.getId());
        markStudentDTO.setLessonName(mark.getLessonName());
        markStudentDTO.setGrade(mark.getGrade());
        markStudentDTO.setCreationDate(mark.getCreationDate());
        markStudentDTO.setStudent(studentToStudentDTO(mark.getStudent()));

        return markStudentDTO;
    }

    @Override
    public List<MarkStudentDTO> marksToMarkStudentDTOs(List<Mark> marks) {
        return marks.stream().map(this::markToMarkStudentDTO).collect(Collectors.toList());
    }

    public StudentDTO studentToStudentDTO(Student student) {
        if (student == null) {
            return null;
        }
        StudentDTO studentDTO = new StudentDTO();
        studentDTO.setId(student.getId());
        studentDTO.setName(student.getName());
        studentDTO.setSurname(student.getSurname());

        return studentDTO;
    }

    public List<MarkDTO> marksToMarksDTOs(List<Mark> marks) {
        if (marks == null) {
            return null;
        }
        List<MarkDTO> markDTOs = new ArrayList<>();
        for (Mark mark : marks) {
            MarkDTO markDTO = new MarkDTO();
            markDTO.setId(mark.getId());
            markDTO.setLessonName(mark.getLessonName());
            markDTO.setGrade(mark.getGrade());
            markDTO.setCreationDate(mark.getCreationDate());
            markDTOs.add(markDTO);
        }

        return markDTOs;
    }
}
