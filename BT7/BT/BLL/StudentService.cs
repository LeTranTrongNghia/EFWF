using DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class StudentService
    {
        public static List<Student> GetAll()
        {
            StudentModels context = new StudentModels();
            return context.Students.ToList();
        }

        public static List<Student> GetAllHasNoMajor()
        {
            StudentModels context = new StudentModels();
            return context.Students.Where(p => p.MajorID == null).ToList();
        }

        public static List<Student> GetAllHasNoMajor(int facultyID)
        {
            StudentModels context = new StudentModels();
            return context.Students.Where(p => p.MajorID == null && p.FacultyID == facultyID).ToList();
        }

        public static Student FindByID(string studentID)
        {
            StudentModels context = new StudentModels();
            return context.Students.FirstOrDefault(p => p.StudentID == studentID);
        }

        public static void InsertUpdate(Student s)
        {
            StudentModels context = new StudentModels();
            context.Students.AddOrUpdate(s);
            context.SaveChanges();
        }
    }
}
