using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Student
{
    public int ID { get; set; }
    public string Name { get; set; }
    public double Grade { get; set; }
}

class Program
{
    static void Main()
    {
        Dictionary<int, Student> students = new Dictionary<int, Student>
        {
            { 1, new Student { ID = 1, Name = "Giangmovie", Grade = 8 } },
            { 2, new Student { ID = 2, Name = "Giangtrasua", Grade = 7 } },
            { 3, new Student { ID = 3, Name = "Giangthitnuong", Grade = 9} },
            { 4, new Student { ID = 4, Name = "Giangcomga", Grade = 6 } },
            { 5, new Student { ID = 5, Name = "Giangduahau", Grade = 5 } }
        };
        var topStudent = students.Values.OrderByDescending(s => s.Grade).FirstOrDefault();
        Console.WriteLine($"Sinh vien co diem cao nhat: {topStudent.Name}, Diem: {topStudent.Grade}");
        double threshold = 7;
        var studentsAboveThreshold = students.Values
                                             .Where(s => s.Grade > threshold)
                                             .Select(s => s.Name)
                                             .ToList();
        Console.WriteLine("Danh sach sinh vien co diem lon hon " + threshold + ":");
        studentsAboveThreshold.ForEach(Console.WriteLine);
        int countAboveAverage = students.Values.Count(s => s.Grade >= 5);
        Console.WriteLine("So luong sinh vien co diem trung binh tro len: " + countAboveAverage);
        Console.ReadKey();
    }
}

