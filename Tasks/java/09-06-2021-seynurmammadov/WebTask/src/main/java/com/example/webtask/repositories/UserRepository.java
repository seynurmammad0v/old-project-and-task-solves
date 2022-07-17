package com.example.webtask.repositories;

import com.example.webtask.models.MyUser;
import org.springframework.data.jpa.repository.JpaRepository;

public interface UserRepository extends JpaRepository<MyUser, Long> {
    MyUser findMyUserByUsername(String username);
}