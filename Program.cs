using System;
using System.Collections.Generic;
using System.Linq;


namespace BT02
{
    internal class BT02_01
    {

    }
}

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}
public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;
        // nhập danh sách học sinh 
        List<Student> students = new List<Student>()
        {
            new Student { Id = 1, Name = "Anh", Age = 16 },
            new Student { Id = 2, Name = "Binh", Age = 14 },
            new Student { Id = 3, Name = "Cuong", Age = 17 },
            new Student { Id = 4, Name = "Dung", Age = 19 },
            new Student { Id = 5, Name = "An", Age = 15 },
            new Student { Id = 6, Name = "Hoa", Age = 18 }
        };

        // a.in danh sách toàn bộ học sinh
        Console.WriteLine("a. Danh sách toàn bộ học sinh:");
        PrintStudents(students);

        // b.tìm và in ra học sinh tuổi từ 15-18
        Console.WriteLine("\nb. Học sinh tuổi từ 15-18:");
        var studentsAge15to18 = students.Where(s => s.Age >= 15 && s.Age <= 18);
        PrintStudents(studentsAge15to18);

        // c.tìm và in ra học sinh có tên bắt đầu bằng chữ "A"
        Console.WriteLine("\nc. Học sinh có tên bắt đầu bằng chữ A:");
        var studentsStartWithA = students.Where(s => s.Name.StartsWith("A", StringComparison.OrdinalIgnoreCase));
        PrintStudents(studentsStartWithA);

        // d.tính tổng tuổi của tất cả học sinh
        int totalAge = students.Sum(s => s.Age);
        Console.WriteLine($"\nd. Tổng số tuổi của tất cả học sinh: {totalAge}");

        // e.tìm và in ra học sinh có tuổi lớn nhất
        var oldestStudent = students.OrderByDescending(s => s.Age).FirstOrDefault();
        if (oldestStudent != null)
        {
            Console.WriteLine("\ne. Học sinh có tuổi lớn nhất:");
            Console.WriteLine($"  ID: {oldestStudent.Id}, Tên: {oldestStudent.Name}, Tuổi: {oldestStudent.Age}");
        }

        // f.sắp xếp danh sách học sinh theo tên tăng dần
        Console.WriteLine("\nf. Danh sách học sinh tăng dần theo tên (A-Z):");
        var sortedStudents = students.OrderBy(s => s.Name);
        PrintStudents(sortedStudents);
    }

    // Hàm tiện ích để in danh sách học sinh
    public static void PrintStudents(IEnumerable<Student> studentList)
    {
        foreach (var s in studentList)
        {
            Console.WriteLine($"  ID: {s.Id}, Ten: {s.Name}, Tuoi: {s.Age}");
        }
    }
}
