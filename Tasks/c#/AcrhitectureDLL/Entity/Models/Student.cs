using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Models
{
    public class Student:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
