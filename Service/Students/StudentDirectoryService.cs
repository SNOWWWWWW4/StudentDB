using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using StudentDB.Data;
using StudentDB.Models;

namespace StudentDB.Service.Students
{
    public class StudentDirectoryService : IStudentDirectoryService
    {
        private readonly DataContext _db;

        public StudentDirectoryService(DataContext db)
        {
            _db = db;
        }
        public List<Student> AddStudent(string firstName, string lastName, string hobby)
        {
            Student newStudent = new()
            {
                Name = firstName,
                Last = lastName,
                Hob = hobby
            };

            _db.Students.Add(newStudent);
            _db.SaveChanges();

            return _db.Students.ToList();
        }

        public List<Student> DeleteStudent(string firstName, string lastName, string hobby)
        {
            var student = _db.Students.FirstOrDefault(foundStudent => foundStudent.Name == firstName);

            var hobb = _db.Students.FirstOrDefault(foundHobby => foundHobby.Hob == hobby);

            var lastNam = _db.Students.FirstOrDefault(foundLast => foundLast.Last == lastName);


            if(student != null && hobb != null && lastNam != null ){
                _db.Students.Remove(student);
                _db.Students.Remove(hobb);
                _db.Students.Remove(lastNam);
                _db.SaveChanges();
            }

            return _db.Students.ToList();
            
        }

        public List<Student> GetStudents()
        {
            return _db.Students.ToList();
        }
    }
}