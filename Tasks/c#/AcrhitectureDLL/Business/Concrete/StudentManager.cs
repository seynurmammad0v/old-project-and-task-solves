using Business.Abstract;
using DataAccess.Abstract;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class StudentManager : IStudentService
    {
        private readonly IStudentDAL _studentDAL;

        public StudentManager(IStudentDAL studentDAL)
        {
            _studentDAL = studentDAL;
        }

        public List<Student> GetAllStu()
        {
            return _studentDAL.GetAll();
        }

        public Student GetStuWithId(int id)
        {
            return _studentDAL.Get(s => s.Id == id);
        }

        public void Add(Student student)
        {
            _studentDAL.Add(student);
        }

        public void Detele(int id)
        {
            _studentDAL.Delete(new Student { Id = id });
        }

        public void Update(Student student)
        {
            _studentDAL.Update(student);
        }
    }
}
