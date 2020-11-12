using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;

namespace DemoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ArrayList arrayList = new ArrayList();
            arrayList.Add(12);
            arrayList.Add("Satya");

            int id = (int)arrayList[1];
            Write<int>(10, 20);
            Write<double>(10.5D, 26.4D);
            Write<string>("Satya", "Mutyala");

            List<int> numbers = new List<int>();
            List<string> Names = new List<string>();

            numbers.Add(12);
            Names.Add("Satya");

            Repository<Student> students = new Repository<Student>();
            Repository<Course> Courses = new Repository<Course>();

            //FIFO
            Queue<Student> registrationQueue = new Queue<Student>();

            //LIFO
            Stack<Course> courseStack = new Stack<Course>();

            Dictionary<int, string> myDictonay = new Dictionary<int, string>();

            List<Student> Highcredits = students.GetTopCredits();
            List<Course> HighcreditCourses = Courses.GetTopCredits();
            

            
        }

        private static string Write<TType>(TType Item1, TType Item2)
        {
            return $"{Item1.ToString()}, {Item2.ToString()}";
        }

    }
}
