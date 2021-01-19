using System;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string student1 = "Engin";
            string student2 = "Derin";
            string student3 = "Salih";

            string[] students = new string[3];
            students[0] = "Engin";
            students[1] = "Derin";
            students[2] = "Salih";

            string[] students2 = new[] { "Ayşe", "Fatma", "Hayriye" };
          

            foreach(var student in students)
            {

                Console.WriteLine(student);
            }
            foreach(var students1 in students2)
            {
                Console.WriteLine(students1);
            }
            Console.WriteLine();
            //----OUTPUT----//
            //Engin
            //Derin
            //Salih


            //-----OUTPUT---//
            //Ayşe
            //Fatma
            //Hayriye

        }
    }
}
