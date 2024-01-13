using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentDB.Models;

namespace StudentDB.Service.Students
{
    public interface IStudentDirectoryService
    {
        List<Student> GetStudents();
        List<Student> AddStudent(string firstName, string lastName, string hobby);
        List<Student> DeleteStudent(string firstName, string lastName, string hobby);
    }
}