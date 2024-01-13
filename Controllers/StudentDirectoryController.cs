using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentDB.Models;
using StudentDB.Service.Students;

namespace StudentDB.Controllers
{
    public class StudentDirectoryController
    {
        private readonly IStudentDirectoryService _studentDirectoryService;

        public StudentDirectoryController(IStudentDirectoryService StudentDirectoryService)
        {
            _studentDirectoryService = StudentDirectoryService;
        }
        [HttpGet ("FetchQuest")]
        public List<Student> GetStudents()
        {
            return _studentDirectoryService.GetStudents();
        }


        [HttpPost ("AddStudent/{firstName}/{lastName}/{hobby}")]
        public List<Student> AddStudent(string firstName, string lastName, string hobby)
        {
            return _studentDirectoryService.AddStudent(firstName, lastName, hobby);
        }


        [HttpDelete ("DeleteStudent/{firstName}/{lastName}/{hobby}")]
        public List<Student> DeleteStudent(string firstName, string lastName, string hobby)
        {
            return _studentDirectoryService.DeleteStudent(firstName, lastName, hobby);
        }
    }
}