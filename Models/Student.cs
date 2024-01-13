using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentDB.Models
{
    public class Student
    {
        public int Id{get; set;}
        public string Name{ get; set;} = "Robert";
        public string Last{ get; set;} = "De la Olla";
        public string Hob{ get; set;} = "Eating";

        
    }
}