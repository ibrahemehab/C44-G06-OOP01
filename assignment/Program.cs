using assignment.enums;
using System.ComponentModel;
using System.Net;

namespace assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region example 1 
            //Person person = new Person();
            //person.id = 1;
            //person.name = "medo";
            //person.gender = Gender.male;

            //Console.WriteLine(person.gender);
            //Grade grade = new Grade();
            //grade = Grade.c;
            //Console.WriteLine((int)grade); 
            #endregion
            #region example 2 
            //bool isparsed;
            //int id;
            //object gender;
            //object grade;
            //object branch;
            //student student = new student();
            //Console.WriteLine("please enter student data :");
            //do
            //{
            //    Console.WriteLine("enter the id :");
            //    isparsed = int.TryParse(Console.ReadLine(), out id);
            //    if (isparsed == false )
            //        Console.WriteLine("in valid input ");
            //} while (isparsed == false );
            //student.id = id;
            //Console.WriteLine("enter the name :");
            //student.name = Console.ReadLine();
            //Console.WriteLine("enter the gender :");
            //do
            //{
            //    isparsed = Enum.TryParse(typeof(Gender),Console.ReadLine(),true,out gender );
            //} while (isparsed == false);
            //student.gender = (Gender)gender;
            //Console.WriteLine("enter the grade :");
            //do
            //{
            //    isparsed = Enum.TryParse(typeof(Grade), Console.ReadLine(),true, out grade);
            //} while (isparsed == false);
            //student.grade = (Grade)grade;
            //Console.WriteLine("enter the branch :");
            //do
            //{
            //    isparsed = Enum.TryParse(typeof(Branch), Console.ReadLine(),true, out branch);
            //} while (isparsed == false);
            //student.branch = (Branch)branch;
            //Console.WriteLine($"the student data is id = {id}  name is {student.name} gendre is {student.gender} grade is {student.grade} branch is {student.branch} ");

            #endregion
            #region example 3
            //user user = new user();
            //user.id = 1;
            //user.Permissions[0] = true;
            //user.Permissions[1] = false;
            //user.Permissions[2] = false;
            //user.Permissions[3] = false;
            //Console.WriteLine(user.Permissions.ToString());
            //user.permissions = (Permissions)10;
            //user.permissions = user.permissions | Permissions.read;
            //Console.WriteLine(user.permissions);

            #endregion
            #region q1
            //Create an enum called "WeekDays" with the days of the week
            //(Monday to Sunday) as its members.Then, write a C# program that
            //prints out all the days of the week using this enum.
            Weekdays weekdays = new Weekdays();
            weekdays = (Weekdays)127;
            Console.WriteLine(weekdays);
            #endregion
        }
    }
}       
