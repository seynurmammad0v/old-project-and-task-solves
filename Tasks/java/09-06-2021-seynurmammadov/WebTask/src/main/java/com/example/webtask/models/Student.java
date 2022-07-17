package com.example.webtask.models;

import lombok.*;
import org.springframework.stereotype.Component;

import javax.persistence.*;
import java.util.List;
@Setter
@Getter
@Builder(toBuilder = true)
@NoArgsConstructor
@AllArgsConstructor
@Component
@Entity
@Table(name="students")
public class Student {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private long id;
    private String name;
    private String surname;
    @OneToMany(cascade = CascadeType.ALL,mappedBy = "student",fetch = FetchType.LAZY)
    private List<Mark> markList;

}

