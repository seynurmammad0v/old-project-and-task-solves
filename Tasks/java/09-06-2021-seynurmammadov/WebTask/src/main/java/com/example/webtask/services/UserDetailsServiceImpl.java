package com.example.webtask.services;

import com.example.webtask.models.MyUser;
import com.example.webtask.repositories.UserRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.security.core.userdetails.User;
import org.springframework.security.core.userdetails.UserDetails;
import org.springframework.security.core.userdetails.UserDetailsService;
import org.springframework.security.core.userdetails.UsernameNotFoundException;
import org.springframework.stereotype.Service;

@Service
public class UserDetailsServiceImpl implements UserDetailsService {

    private final UserRepository userRepository;

    public UserDetailsServiceImpl(UserRepository userRepository) {
        this.userRepository = userRepository;
    }

    @Override
    public UserDetails loadUserByUsername(String username) {
        MyUser user = userRepository.findMyUserByUsername(username);
        System.out.println(user.getUsername());
        System.out.println("++++++++");
        if (user == null) {
            throw new UsernameNotFoundException(username);
        }
        return new User(user.getUsername(),user.getPassword(), user.getRoles());
    }

}
