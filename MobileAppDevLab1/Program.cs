using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace MobileAppDevLab1
{
    enum test { Computer_Science, Accounting, Marketing, Nursing }

    class Program
    {
        static void Main(string[] args)
        {
            Boolean keepGoing = false;
            List<Person> myAL = new List<Person>();
            do
            {
                Console.WriteLine("Enter a new 1) Student 2) Teacher. Use any other number to exit");
                int personChoice = Int32.Parse(Console.ReadLine());

                switch (personChoice)
                {
                    case 1:
                        keepGoing = true;
                        Student newStudent = new Student();
                        Console.WriteLine("Name:");
                        newStudent.name = Console.ReadLine();
                        Console.WriteLine("Age:");
                        newStudent.age = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("ID:");
                        newStudent.id = Console.ReadLine();
                        Console.WriteLine("Program: 1) Computer Science. 2) Accounting. 3) Marketing. 4) Nursing");
                        newStudent.Program = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Credits Earned: ");
                        newStudent.credits = Int32.Parse(Console.ReadLine());
                        myAL.Add(newStudent);

                        break;
                    case 2:
                        keepGoing = true;
                        Teacher newTeacher = new Teacher();
                        Console.WriteLine("Name:");
                        newTeacher.name = Console.ReadLine();
                        Console.WriteLine("Age:");
                        newTeacher.age = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("ID:");
                        newTeacher.id = Console.ReadLine();
                        Console.WriteLine("Program: 1) Computer Science. 2) Accounting. 3) Marketing. 4) Nursing");
                        newTeacher.Program = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Years of Service: ");
                        newTeacher.YearsOfService = Int32.Parse(Console.ReadLine());
                        myAL.Add(newTeacher);
                        break;
                    default:
                        keepGoing = false;
                        
                    break;

                }
            } while (keepGoing == true);

            foreach (Person person in myAL)
            {
                Console.WriteLine("-------------- ");

                Console.WriteLine("Name: " + person.name);
                Console.WriteLine("ID: " + person.id);
                Console.WriteLine("Program: " + (test)person.Program);
                Console.WriteLine("Age: " + person.age);
                

                if (person is Student)
                {
                    Student studentPerson = (Student)person;
                    Console.WriteLine("Credits: " + studentPerson.credits);

                }
                else if(person is Teacher)
                {
                    Teacher teacherPerson = (Teacher)person;
                    Console.WriteLine("Years of service: " + teacherPerson.YearsOfService);

                }
            }
            Console.ReadLine();
        }
    }
}
