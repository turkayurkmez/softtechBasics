using System;
using System.Collections.Generic;

namespace BuiltInInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Student> students = new List<Student> { }
            StudentService studentService = new StudentService();
            studentService.AddRange(new Student { Id = 1, Name = "Türkay", LastName = "Ürkmez", Age = 42, Score = 78 },
                                    new Student { Id = 2, Name = "Aygün", LastName = "Mercan", Age = 24, Score = 92 },
                                    new Student { Id = 3, Name = "İnci", LastName = "Karagülle", Age = 18, Score = 50 },
                                    new Student { Id = 4, Name = "Özge", LastName = "Bulut", Age = 32, Score = 65 }

                                    );

            studentService.Sort();

            foreach (var student in studentService )
            {
                Console.WriteLine($"{student.Name} {student.LastName} {student.Age} {student.Score}");
            }
        }

      
    }
}
