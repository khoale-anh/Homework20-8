using System;

public class Student
{
    private string name;
    private double score;
    private static int totalStudents = 0;

    public Student(string name, double score)
    {
        this.name = name;
        this.score = score;
        totalStudents++;
    }

    // ===== Instance Methods (dùng this, thao tác trên 1 object cụ thể) =====

    public string GetName()
    {
        return this.name;
    }

    public double GetScore()
    {
        return this.score;
    }

    public bool IsPassed()
    {
        return this.score >= 5.0;
    }

    public string GetClassification()
    {
        if (this.score >= 8.0) return "Excellent";
        if (this.score >= 6.5) return "Good";
        if (this.score >= 5.0) return "Average";
        return "Weak";
    }

    // ===== Static Methods (không dùng this, thao tác trên dữ liệu chung / tham số) =====

    public static int GetTotalStudents()
    {
        return totalStudents;
    }

    public static Student FindTopStudent(Student[] students)
    {
        if (students == null || students.Length == 0) return null;

        Student top = students[0];
        for (int i = 1; i < students.Length; i++)
        {
            if (students[i].GetScore() > top.GetScore())
            {
                top = students[i];
            }
        }
        return top;
    }

    public static double CalculateAverageScore(Student[] students)
    {
        if (students == null || students.Length == 0) return 0;

        double sum = 0;
        foreach (Student s in students)
        {
            sum += s.GetScore();
        }
        return sum / students.Length;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // 1. Tạo mảng ít nhất 5 Student với tên và điểm khác nhau
        Student[] students = new Student[]
        {
            new Student("An", 8.5),
            new Student("Binh", 6.7),
            new Student("Chi", 4.2),
            new Student("Duc", 5.8),
            new Student("Em", 9.1)
        };

        // 2. In tổng số sinh viên đã tạo (dùng static method)
        Console.WriteLine("Total students created: " + Student.GetTotalStudents());
        Console.WriteLine();

        // 3. In danh sách sinh viên kèm xếp loại và trạng thái đậu/rớt (dùng instance methods)
        Console.WriteLine("Student List:");
        foreach (Student s in students)
        {
            string status = s.IsPassed() ? "Passed" : "Failed";
            Console.WriteLine($"- {s.GetName()}: Score = {s.GetScore()}, " +
                               $"Classification = {s.GetClassification()}, Status = {status}");
        }
        Console.WriteLine();

        // 4. In sinh viên có điểm cao nhất (dùng static method)
        Student top = Student.FindTopStudent(students);
        Console.WriteLine($"Top student: {top.GetName()} with score {top.GetScore()}");
        Console.WriteLine();

        // 5. In điểm trung bình của cả lớp (dùng static method)
        double avg = Student.CalculateAverageScore(students);
        Console.WriteLine($"Class average score: {avg:F2}");
    }
}