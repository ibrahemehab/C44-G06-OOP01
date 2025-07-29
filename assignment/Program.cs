using assignment.enums;
using System;
using System.ComponentModel;
using System.Net;
using System.Text;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            //Weekdays weekdays = new Weekdays();
            //weekdays = (Weekdays)127;
            //Console.WriteLine(weekdays);
            #endregion
            #region q2
            //Create an enum called "Season" with the four seasons (Spring,
            //Summer, Autumn, Winter) as its members.Write a C# program that
            //takes a season name as input from the user and displays the
            //corresponding month range for that season. Note range for seasons(
            //spring march to may, summer june to august, autumn September to
            //November, winter December to February)
            object season;
            bool isparsed;
            do
            {
                Console.WriteLine("enter the season : ");
                isparsed = Enum.TryParse(typeof(Season), Console.ReadLine(), true, out season);
                if (isparsed == false)
                    Console.WriteLine("invalid season try again ");
            } while ( isparsed == false );
            Season season1 = new Season();
            season1 =(Season)season;
            switch (season1)
            {
                case Season.spring:
                    Console.WriteLine("the range is march to may");
                    break;
                case Season.winter:
                    Console.WriteLine("the range is december to feburary");
                    break;
                case Season.summer:
                    Console.WriteLine("the range is june to august ");
                    break;
                case Season.autumn:
                    Console.WriteLine("the range is september to november ");
                    break;
            }
            #endregion
        }
    }
}       
