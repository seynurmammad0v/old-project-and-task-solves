package com.example.webtask.models;

import com.fasterxml.jackson.annotation.JsonIgnore;
import lombok.*;
import org.hibernate.secure.spi.GrantedPermission;
import org.springframework.security.core.GrantedAuthority;

import javax.persistence.*;

@Entity
@Builder
@Data
@NoArgsConstructor
@AllArgsConstructor
@ToString
@Table(name = "roles")
public class Role implements GrantedAuthority {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;
    private String name;
    @ManyToOne
    @JoinColumn(name = "myUser_id")
    @JsonIgnore
    private MyUser myUser;
    @Override
    public String getAuthority() {
        return name;
    }
}