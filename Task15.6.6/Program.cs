using System;
using System.Collections.Generic;
using System.Linq;

namespace Task15._6._6
{
    class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
            {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };

            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join(" ", allStudents));
            Console.ReadKey();
        }

        static string[] GetAllStudents(Classroom[] classes)
        {
            var result = new List<string>();
            foreach (var item in classes)
            {
                result.AddRange(item.Students);
            }
            return result.Distinct().ToArray();
        }
    }
    public class Classroom
    {
        public List<string> Students = new List<string>();
    }
}
