package com.example.webtask.models.dto.mapper.interfaces;

import com.example.webtask.models.Mark;
import com.example.webtask.models.Student;
import com.example.webtask.models.dto.MarkStudentDTO;
import com.example.webtask.models.dto.StudentMarkDTO;

import java.util.List;

public interface MapStructMapper {
    StudentMarkDTO studentToStudentMarkDTO(Student student);

    List<StudentMarkDTO> studentsToStudentMarkDTOs(List<Student> students);

    MarkStudentDTO markToMarkStudentDTO(Mark mark);

    List<MarkStudentDTO> marksToMarkStudentDTOs(List<Mark> marks);

}
