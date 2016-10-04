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
            // This could be a menu
            // Or it could be something else.
            RunStudent rs = new RunStudent();
            rs.topMenu();

        }

        public void topMenu()
        {
            int input;

            do
            {
                Console.WriteLine("1) Populate Students");
                Console.WriteLine("2) Exit");

                input = Convert.ToInt32(Console.ReadLine());
                if (input == 1)
                {
                    populateStudents();
                }
            } while (input != 2);
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

                stuArray[i] = new Student(tempname, tempex1, tempex2);
            }
        }
    }
}
