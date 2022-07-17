package com.example.CRUDapplication;

import com.example.CRUDapplication.models.Student;
import com.google.gson.Gson;

import javax.servlet.http.HttpServletRequest;
import java.io.BufferedReader;
import java.io.IOException;

public class JsonManipulations {
    public static Student readToObject(HttpServletRequest request) throws IOException {
        StringBuffer jb = new StringBuffer();
        String line;
        BufferedReader reader = request.getReader();
        while ((line = reader.readLine()) != null) {
            jb.append(line);
        }
        Gson gson = new Gson();
        Student student = gson.fromJson(jb.toString(), Student.class);
        return student;
    }

    public static String objToJson(Student student) throws IOException {
        Gson gson = new Gson();
        return gson.toJson(student);
    }
}
