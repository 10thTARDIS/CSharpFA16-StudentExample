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
        double avg;
        
        public Student(String arg_name, int ex1, int ex2)
        {
            name = arg_name;
            exam1 = ex1;
            exam2 = ex2;
        }

        public void calcAvg()
        {
            avg = (exam1 + exam2) / 2.0;
        }

        public void determineLetterGrade()
        {
            if(avg >= 90)
            {
                lettergrade = 'A';
            }
            else if (avg >= 80)
            {
                lettergrade = 'B';
            }
            else if (avg >= 70)
            {
                lettergrade = 'C';
            }
            else if (avg >= 60)
            {
                lettergrade = 'D';
            }
            else if (avg <= 60)
            {
                lettergrade = 'F';
            }
            Console.WriteLine(name + "'s average score was " + lettergrade);
        }



    }
}
