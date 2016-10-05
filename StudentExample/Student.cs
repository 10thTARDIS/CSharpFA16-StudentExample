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
        int lettergrade;
        double avg;
        
        public Student(String arg_name, int ex1, int ex2)
        {
            name = arg_name;
            exam1 = ex1;
            exam2 = ex2;
        }

        public void calcAvg()
        {
            avg = (exam1 + exam2) / 2;
        }

        public void determineLetterGrade()
        {
            if(avg >= 90)
            {
                lettergrade = 'A';
                Console.WriteLine(name + "'s final grade is: A);
            }
            else if (avg >= 80 && avg <= 90)
            {
                lettergrade = 'B';
            }
            else if (avg >= 70 && avg <= 80)
            {
                lettergrade = 'C';
            }
            else if (avg >= 60 && avg <= 70)
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
