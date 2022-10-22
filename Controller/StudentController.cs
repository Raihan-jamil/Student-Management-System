using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using StudentManagement.Data;
using StudentManagement.Model;
using StudentManagement.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Controller
{
    class StudentController
    {
        public StudentController(){}
        StudentServiceImpl studentService = new StudentServiceImpl();
        public void showStudents()
        {
            var ListOfStudents = studentService.viewAllStudents();
            foreach(var student in ListOfStudents)
            {
                Console.WriteLine(student.ToString());
            }
        }
        public void addStudent()
        {
            Console.WriteLine("FirstName : ");
            string FirstName = Console.ReadLine();
            Console.WriteLine("MiddleName : ");
            string LastName = Console.ReadLine();
            Console.WriteLine("LastName : ");
            string MiddleName = Console.ReadLine();
            Console.WriteLine("StudentId : ");
            string StudentId = Console.ReadLine();
            Console.WriteLine("Semester Inforation : Year ? ");
            string Year = Console.ReadLine();
            Console.WriteLine("Semester Inforation : Fall/Spring/Summer ? ");
            string Semestername = Console.ReadLine();
            Console.WriteLine("Department Name : CSE/BBA/English? ");
            string department = Console.ReadLine();
            Department dept;
            Enum.TryParse<Department>(department, out dept);
            Console.WriteLine("Department Name : BSC/BA/MSC/BBA/MBA/MA? ");
            string degree = Console.ReadLine();
            Degree deg;
            Enum.TryParse<Degree>(degree, out deg);
            SemesterModel semester = new SemesterModel(Year, Semestername);
            List<SemesterModel> semesterModels = new List<SemesterModel>();
            semesterModels.Add(semester);
            List<CourseModel> courses = new List<CourseModel>();
            StudentModel studentModel = new StudentModel(FirstName, MiddleName, LastName, StudentId, semester, dept, deg, semesterModels, courses);
            studentService.addStudent(studentModel);
        }
        public void deleteStudent()
        {
            int id = Convert.ToInt32(Console.ReadLine());
            studentService.deleteStudent(id);
        }
        public void viewStudent()
        {

        }
    }
}
