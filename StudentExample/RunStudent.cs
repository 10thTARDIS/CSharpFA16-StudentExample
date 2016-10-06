using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentExample
{
    class RunStudent
    {
        Student[] stuArray = new Student[3];

        static void Main(string[] args)
        {
            RunStudent rs = new RunStudent();
            rs.topMenu();

        }

        public void topMenu()
        {
            int input;

            do
            {
                Console.WriteLine("1) Populate Students");
                Console.WriteLine("2) Pick Student");
                Console.WriteLine("3) Exit");

                input = Convert.ToInt32(Console.ReadLine());
                if (input == 1)
                {
                    populateStudents();
                }
                else if (input == 2)
                {
                    pickStudent();
                }
            } while (input != 3);
        }

        public void populateStudents()
        {
            for (int i = 0; i < stuArray.Length; i++)
            {
                Console.WriteLine("Please enter name: ");
                String tempname = Console.ReadLine();
                Console.WriteLine("Please enter Exam One score: ");
                int tempex1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter Exam Two score: ");
                int tempex2 = Convert.ToInt32(Console.ReadLine());

                //Student stu = new Student();
                //stu.determineLetterGrade();

                stuArray[i] = new Student(tempname, tempex1, tempex2);
            }
        }
        public void pickStudent()
        {
            Console.WriteLine("Please enter student name: ");
            String tempname = Console.ReadLine();
            int counter = 0;
            for (int i = 0; i < stuArray.Length; i++)
            {
                if(stuArray[i].name.Equals(tempname))
                {
                    counter = i;
                }
            }
            if(counter != 1)
            {
                stuArray[counter].calcAvg();
                stuArray[counter].determineLetterGrade();
            }
            else
            {
                Console.WriteLine("There's nothing here.  Who you gonna call? \n ...I think you better call... \n ...GHOSTBUSTERS!");
            }
        }
    }
}
