using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentExample
{
    class Student
    {
        public String name { get; set; }
        int exam1 { get; set; }
        int exam2 { get; set; }
        char lettergrade;
        
        public Student(String arg_name, int ex1, int ex2)
        {
            name = arg_name;
            exam1 = ex1;
            exam2 = ex2;
        }



    }
}
