using System;
using System.Collections.Generic;
using System.Linq;
using HomeWork3._1;

public class Program
{
    static void Main()
    {
        int maxGrade = 12;
        int minGrade = 1;

        var grades = new List<Student>
        {
            new Student
            {
                Name = "Alex",
                Surname = "Florov",
                Grade = 12,
            },
            new Student
            {
                Name = "Misha",
                Surname = "Deminov",
                Grade = 1,
            },
            new Student
            {
                Name = "Jack",
                Surname = "Lomoch",
                Grade = 7,
            }
        };

        //int bestGrade = grades.Max(g => g.Grade);
        var maxGrades = grades.OrderByDescending(x => x.Grade).First();
        Console.WriteLine($"{maxGrades.Name} {maxGrades.Surname} grade: {maxGrades.Grade}");
    }
}