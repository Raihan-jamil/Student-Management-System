using Newtonsoft.Json;
using StudentManagement.Controller;
using StudentManagement.Data;
using StudentManagement.Model;
using System;
using System.Collections.Generic;
using System.IO;

namespace StudentManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data Initialization
            //Initial Courses
            List<CourseModel> Courses = new List<CourseModel>
            {
                new CourseModel("1", "Computer Fundamentals", "Ishrat Mam", 3),
                new CourseModel("2", "E Commerce", "Moazzem Sir", 3)
            };
            string ListOfCourses = JsonConvert.SerializeObject(Courses);
            File.WriteAllText(@"D:\StudentManagementDBFile\ListOfCourses.json", ListOfCourses);

            //Initial Semesters
            List<SemesterModel> Semesters = new List<SemesterModel>
            {
                new SemesterModel("2022", SemesterName.Spring),
                new SemesterModel("2021", SemesterName.Fall)
            };
            string ListOfSemesters = JsonConvert.SerializeObject(Semesters);
            File.WriteAllText(@"D:\StudentManagementDBFile\ListOfSemesters.json", ListOfSemesters);

            //Initial Students
            List<StudentModel> Students = new List<StudentModel>
            {
                new StudentModel("MD.","Raihan","Jamil","1",
                Semesters[0], Department.CSE, Degree.BSC,
                Semesters, Courses),
                new StudentModel("MD.","Taher","Irfan","2",
                Semesters[0], Department.CSE, Degree.BSC,
                Semesters, Courses),
            };
            string ListOfStudents = JsonConvert.SerializeObject(Students);
            File.WriteAllText(@"D:\StudentManagementDBFile\ListOfStudents.json", ListOfStudents);

            //Show Initial Students
            StudentController studentController = new StudentController();
            studentController.showStudents();

            //User Input
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("Enter :" + "1 --> Add New Student" + "2 --> View Student" + "3 --> Delete Student");
                int Input = Convert.ToInt32(Console.ReadLine());
                if (Input == 1) studentController.addStudent();
                studentController.showStudents();
            }
        }
    }
}
