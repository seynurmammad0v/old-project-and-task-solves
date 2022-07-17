package com.example.CRUDapplication;

import com.example.CRUDapplication.models.Student;

import java.io.*;
import java.util.List;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;
import javax.servlet.http.*;
import javax.servlet.annotation.*;

@WebServlet(name = "students", value = "/students ")
public class Students extends HttpServlet {
    EntityManagerFactory emf;
    CRUD crud;

    public void init() {
        emf = Persistence.createEntityManagerFactory("servlet_task");
        crud = new CRUD(emf);
    }

    public void doGet(HttpServletRequest request, HttpServletResponse response) throws IOException {
        PrintWriter out = response.getWriter();
        if (request.getParameter("id") != null) {
            long id = Long.parseLong(request.getParameter("id"));
            Student student = crud.findById(id);
            if (student != null) {
                out.println(JsonManipulations.objToJson(student));
            } else {
                out.println("Student with this id not found");
            }
        } else {
            List<Student> studentList = crud.getAll();
            studentList.forEach(s -> {
                try {
                    out.println(JsonManipulations.objToJson(s));
                } catch (IOException e) {
                    e.printStackTrace();
                }
            });
        }
    }

    public void doPost(HttpServletRequest request, HttpServletResponse response) throws IOException {
        Student student = JsonManipulations.readToObject(request);
        crud.mergeToDb(student);
    }

    public void doPut(HttpServletRequest request, HttpServletResponse response) throws IOException {
        long id = Long.parseLong(request.getParameter("id"));
        Student student = JsonManipulations.readToObject(request);
        student.setId(id);
        crud.mergeToDb(student);
    }

    public void doDelete(HttpServletRequest request, HttpServletResponse response) {
        long id = Long.parseLong(request.getParameter("id"));
        crud.delete(id);
    }


    public void destroy() {
    }
}