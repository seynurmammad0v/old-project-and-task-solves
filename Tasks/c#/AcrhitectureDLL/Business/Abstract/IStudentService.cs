using Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IStudentService
    {
        Student GetStuWithId(int id);
        List<Student> GetAllStu();

        void Add(Student student);
        void Update(Student student);
        void Detele(int id);

    }
}
