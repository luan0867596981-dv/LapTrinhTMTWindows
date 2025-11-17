using System;
using System.Collections.Generic;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Faculty { get; set; } 
    public double AverageScore { get; set; } 

    public void Input()
    {
        int id;
        Console.Write("Nhập ID: ");
        while (!int.TryParse(Console.ReadLine(), out id) || id <= 0)
        {
            Console.Write("ID không hợp lệ. Vui lòng nhập lại (số nguyên dương): ");
        }
        this.Id = id;

        Console.Write("Nhập tên: ");
        this.Name = Console.ReadLine();

        int age;
        Console.Write("Nhập tuổi: ");
        while (!int.TryParse(Console.ReadLine(), out age) || age <= 0)
        {
            Console.Write("Tuổi không hợp lệ. Vui lòng nhập lại (số nguyên dương): ");
        }
        this.Age = age;

        Console.Write("Nhập khoa: ");
        this.Faculty = Console.ReadLine();

        double score;
        Console.Write("Nhập điểm trung bình (0-10): ");
        while (!double.TryParse(Console.ReadLine(), out score) || score < 0 || score > 10)
        {
            Console.Write("Điểm không hợp lệ. Vui lòng nhập lại (0-10): ");
        }
        this.AverageScore = score;
    }

    public void Show()
    {
        Console.WriteLine($"  ID: {this.Id}, Ten: {this.Name}, Tuoi: {this.Age}, Khoa: {this.Faculty}, Diem TB: {this.AverageScore:F2}");
    }

    public string GetXepLoai()
    {
        if (AverageScore >= 9.0) return "Xuất sắc";
        if (AverageScore >= 8.0) return "Giỏi";
        if (AverageScore >= 7.0) return "Khá";
        if (AverageScore >= 5.0) return "Trung bình";
        if (AverageScore >= 4.0) return "Yếu";
        return "Kém";
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        List<Student> students = new List<Student>();

        students.Add(new Student { Id = 1, Name = "Anh", Age = 20, Faculty = "QTKD", AverageScore = 9.5 });
        students.Add(new Student { Id = 2, Name = "Thái", Age = 21, Faculty = "CNTT", AverageScore = 7.1 });
        students.Add(new Student { Id = 3, Name = "Phúc", Age = 22, Faculty = "CNTT", AverageScore = 8.8 });
        students.Add(new Student { Id = 4, Name = "Luân", Age = 20, Faculty = "CNTT", AverageScore = 9.5 });
        students.Add(new Student { Id = 5, Name = "Hoa", Age = 23, Faculty = "QTKD", AverageScore = 4.5 });


        int choice;
        do
        {
            Console.WriteLine("\n--- MENU ---");
            Console.WriteLine("1. Thêm sinh viên");
            Console.WriteLine("2. Hiển thị danh sách");
            Console.WriteLine("3. Hiển thị sinh viên khoa CNTT");
            Console.WriteLine("4. Hiển thị sinh viên có điểm TB >= 5");
            Console.WriteLine("5. Sắp xếp sinh viên tăng theo điểm TB");
            Console.WriteLine("6. Hiển thị sinh viên khoa CNTT và điểm TB >= 5");
            Console.WriteLine("7. Hiển thị sinh viên khoa CNTT có điểm cao nhất"); 
            Console.WriteLine("0. Thoát");
            Console.Write("Chọn chức năng: ");

            while (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.Write("Lựa chọn không hợp lệ. Nhập lại: ");
            }

            switch (choice)
            {
                case 1:
                    AddStudent(students);
                    break;
                case 2:
                    DisplayStudentList(students);
                    break;
                case 3:
                    DisplayStudentsByFaculty(students, "CNTT");
                    break;
                case 4:
                    DisplayStudentsWithHighAverageScore(students, 5);
                    break;
                case 5:
                    SortStudentsByAverageScore(students);
                    break;
                case 6:
                    DisplayStudentsByFacultyAndScore(students, "CNTT", 5);
                    break;
                case 7:
                
                    DisplayStudentsWithHighestAverageScoreByFaculty(students, "CNTT");
                    break;
                case 8:
              
                    DisplayGradeStatistics(students);
                    break;
                case 0:
                    Console.WriteLine("Đã thoát.");
                    break;
                default:
                    Console.WriteLine("Không có chức năng này.");
                    break;
            }
        } while (choice != 0);
    }

    static void AddStudent(List<Student> studentList)
    {
        Console.WriteLine("=== Nhập thông tin sinh viên ===");
        Student student = new Student();
        student.Input();
        studentList.Add(student);
        Console.WriteLine("Thêm sinh viên thành công!");
    }

    static void DisplayStudentList(IEnumerable<Student> studentList)
    {
        Console.WriteLine("=== Danh sách chi tiết thông tin sinh viên ===");

        if (!studentList.Any()) 
        {
            Console.WriteLine("  (Chưa có sinh viên nào trong danh sách)");
            return;
        }

        foreach (Student student in studentList)
        {
            student.Show();
        }
    }

    static void DisplayStudentsByFaculty(List<Student> studentList, string faculty)
    {
        Console.WriteLine($"=== Danh sách sinh viên thuộc khoa {faculty} ===");
        var students = studentList.Where(s => s.Faculty.Equals(faculty, StringComparison.OrdinalIgnoreCase));
        DisplayStudentList(students);
    }

    //case 4 (Đã sửa - dùng double)
    static void DisplayStudentsWithHighAverageScore(List<Student> studentList, double minDTB)
    {
        Console.WriteLine($"=== Danh sách sinh viên có điểm TB >= {minDTB} ===");
        var students = studentList.Where(s => s.AverageScore >= minDTB);
        DisplayStudentList(students);
    }

    static void SortStudentsByAverageScore(List<Student> studentList)
    {
        Console.WriteLine("=== Danh sách sinh viên được sắp xếp theo điểm trung bình tăng dần ===");
        var sortedStudents = studentList.OrderBy(s => s.AverageScore);
        DisplayStudentList(sortedStudents);
    }

    static void DisplayStudentsByFacultyAndScore(List<Student> studentList, string faculty, double minDTB)
    {
        Console.WriteLine($"=== Danh sách sinh viên có điểm TB >= {minDTB} và thuộc khoa {faculty} ===");
        var students = studentList.Where(s => s.AverageScore >= minDTB
                                          && s.Faculty.Equals(faculty, StringComparison.OrdinalIgnoreCase));
        DisplayStudentList(students);
    }
    static void DisplayStudentsWithHighestAverageScoreByFaculty(List<Student> studentList, string faculty)
    {
        Console.WriteLine($"=== Danh sách sinh viên khoa {faculty} có điểm TB cao nhất ===");

        var facultyStudents = studentList.Where(s => s.Faculty.Equals(faculty, StringComparison.OrdinalIgnoreCase));

        if (!facultyStudents.Any())
        {
            Console.WriteLine($"  (Khong co sinh vien nao khoa {faculty})");
            return;
        }

        double maxScore = facultyStudents.Max(s => s.AverageScore);

        var topStudents = facultyStudents.Where(s => s.AverageScore == maxScore);

        DisplayStudentList(topStudents);
    }

    static void DisplayGradeStatistics(List<Student> studentList)
    {
        Console.WriteLine("=== Thống kê xếp loại sinh viên ===");

        if (!studentList.Any())
        {
            Console.WriteLine("  (Chưa có sinh viên nào trong danh sách)");
            return;
        }

       
        var gradeGroups = studentList.GroupBy(s => s.GetXepLoai());

        foreach (var group in gradeGroups)
        {
            Console.WriteLine($"  - {group.Key}: {group.Count()} sinh viên");
        }
    }
}