package com.example.webtask.configs;

import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;
import org.springframework.security.config.annotation.web.builders.HttpSecurity;
import org.springframework.security.config.annotation.web.configuration.WebSecurityConfigurerAdapter;
import org.springframework.security.crypto.bcrypt.BCryptPasswordEncoder;
import org.springframework.security.crypto.password.PasswordEncoder;

@Configuration
public class SecurityConfig extends WebSecurityConfigurerAdapter {
    protected void configure(HttpSecurity http) throws Exception {
        http
                .csrf().disable()
                .authorizeRequests()
                .antMatchers( "api/students").hasRole("USER")
                .anyRequest().authenticated()
                .and().httpBasic();
    }

/*
    @Override
    protected void configure(AuthenticationManagerBuilder auth) throws Exception{
        String str =passwordEncoder().encode("seynur");
        System.out.println(str);
        auth.inMemoryAuthentication().withUser("seynur")
                .password(str)
                .roles("USER");

    }
*/

    @Bean
    PasswordEncoder passwordEncoder(){
        return new BCryptPasswordEncoder();
    }
}
