package com.example.webtask.models;

import lombok.*;

import javax.persistence.*;
import java.util.List;

@Entity
@Builder
@Data
@NoArgsConstructor
@AllArgsConstructor
@Table(name = "users")
public class MyUser {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;

    @Column(nullable = false, unique = true)
    private String username;

    private String password;
    @OneToMany(cascade = CascadeType.ALL,mappedBy = "myUser",fetch = FetchType.EAGER)
    private List<Role> roles;
}
