using StaticExtensionTask.Entities;
using System.Text.RegularExpressions;

namespace StaticExtensionTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[1];
            bool createStudent = true;
            do
            {
            Fullname:
                Console.WriteLine("Enter fullname(Name Surname):");
                string fullname = Console.ReadLine();
                if (!Student.CheckFullname(fullname))
                {
                    Console.WriteLine("Fullname is not valid!");
                    goto Fullname;
                }
            GroupNo:
                Console.WriteLine("Group Number (one capital letter and 3 digit natural number):");
                string groupNo = Console.ReadLine();
                if (!Student.CheckGroupNo(groupNo))
                {
                    Console.WriteLine("Group Number is not valid!");
                    goto GroupNo;
                }
                Console.WriteLine("Enter age:");
                byte age = Convert.ToByte(Console.ReadLine());
                students[students.Length - 1] = new Student(fullname, groupNo, age);
                Console.WriteLine("All students: ");
                foreach (var student in students) {
                    Console.WriteLine(student);
                }
                Console.WriteLine("Create next student?(Yes/Y)");
                string resonse = Console.ReadLine().ToLower();
                if (!(resonse == "yes" || resonse == "y"))
                {
                    createStudent = false;
                    continue;
                }
                Array.Resize(ref students, students.Length + 1);
            } while (createStudent);
        }
    }
}