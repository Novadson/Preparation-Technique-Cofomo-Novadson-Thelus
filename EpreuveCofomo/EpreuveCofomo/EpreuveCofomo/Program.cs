using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class Program
{
    public static bool IsTrue(Student student) => student.Age > 20 && student.Age < 29;
    public static void Main()
    {
        List<Student> students = new List<Student>(){
            new Student(){IDStudent = 1,StudentName="Novadson",Age=29},
            new Student(){IDStudent = 2,StudentName="Davidson",Age=25},
            new Student(){IDStudent = 3,StudentName="Jonelson",Age=20},
            new Student(){IDStudent = 4,StudentName="Cadiana",Age=27},
            new Student(){IDStudent = 5,StudentName="Sabrina",Age=24}
        };

        var filterResult = from std in students
                           where IsTrue(std)
                           select std;
        filterResult.ToList().ForEach(st => Console.WriteLine("IDStudent:" + st.IDStudent + "\t" + "Student Name:" + st.StudentName + "\t" + "Student Age:" + st.Age));


    }
}
public class Student
{
    public long IDStudent { get; set; }
    public int Age { get; set; }
    public string StudentName { get; set; }
}
