package com.example.webtask.models.dto;

import com.fasterxml.jackson.annotation.JsonProperty;
import lombok.Getter;
import lombok.Setter;

import java.time.LocalDate;

@Getter
@Setter
public class MarkStudentDTO {
    @JsonProperty("id")
    private long id;

    @JsonProperty("lessonName")
    private String lessonName;

    @JsonProperty("grade")
    private int grade;

    @JsonProperty("creationDate")
    private LocalDate creationDate;

    @JsonProperty("student")
    private StudentDTO student;
}
