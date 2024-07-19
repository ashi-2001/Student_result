using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentResults
{
    public class Test
    {
        private static Dictionary<int, User>
        students = new Dictionary<int, User>();
        private static Dictionary<string, Branch>
        branches = new Dictionary<string, Branch>();

        

        public static void InitializeData()
        {
            List<string> subList = new List<string> { "DSA","OS","DBMS"};

            Branch cs = new Branch("CS", subList);
            branches["CS"] = cs;

            
        }

        public static void AddStudent()
        {
            Console.WriteLine("Welcome to the Student Portal");
            Console.WriteLine("------------");
            Console.WriteLine("Enter student name:");
            string name = Console.ReadLine();
            Console.WriteLine("------------");
            Console.WriteLine("Enter branch:");
            string branch = Console.ReadLine();
            Console.WriteLine("------------");
            Console.WriteLine("Enter roll number:");
            int roll = int.Parse(Console.ReadLine());
            Console.WriteLine("------------");
            Dictionary<string, int> res = new Dictionary<string, int>();

            Console.WriteLine("------------");
            foreach (var subject in branches[branch].Subjects)
            {
                Console.WriteLine("Enter marks for " + subject);
                int marks = int.Parse(Console.ReadLine());
                res[subject] = marks;
            }

            Result result = new Result(res);
            User newStudent = new User(roll, result, branches[branch], name);
            students[roll] = newStudent;
        }

        public static void PrintResult()
        {
            Console.WriteLine("*Wait till we print your result*");
            Console.WriteLine("Enter roll number:");
            int roll = int.Parse(Console.ReadLine());
            Console.WriteLine("------------");
            Console.WriteLine("Result is: ");
            int totalMark = 0;
            int count = 0;
            foreach (var mark in students[roll].Result.GetMarks())
            {
                Console.WriteLine(mark.Key + ": " + mark.Value);
                totalMark += mark.Value;
                count++;
            }
            Console.Write("Percentage :"+totalMark /count+"%");
           
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Test.InitializeData();
            Test.AddStudent();
            Test.PrintResult();
            //    Result cal = new Result();
            //    double percent = (double)cal.CalculatePercentage();
            //    Console.WriteLine(percent.ToString("f2") + "%");
            }
        }
    }
}
