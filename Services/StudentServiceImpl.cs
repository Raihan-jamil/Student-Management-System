using Newtonsoft.Json;
using StudentManagement.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Services
{
    class StudentServiceImpl : IStudentService
    {
        public StudentServiceImpl() { }
        public void addNewSemester(int StudentId, SemesterModel semester)
        {
            throw new NotImplementedException();
        }

        public void addStudent(StudentModel student)
        {
            List<Object> ListOfStudents = viewAllStudents();
            ListOfStudents.Add(student);
            string json = JsonConvert.SerializeObject(ListOfStudents);
            File.WriteAllText(@"D:\StudentManagementDBFile\ListOfStudents.json", json);
        }

        public void deleteStudent(int Id)
        {
            //ToBeImplemented
            /*List<Object> ListOfStudents = viewAllStudents();
            *//*foreach(var v in ListOfStudents)
            {
                Console.WriteLine(v.StudentId );
            }*/
        }

        public void deleteStudents(string Id)
        {
            throw new NotImplementedException();
        }

        public StudentModel singleStudent(string Id)
        {
            throw new NotImplementedException();
        }

        public List<Object> viewAllStudents()
        {
            var lines = File.ReadAllText(@"D:\StudentManagementDBFile\ListOfStudents.json");
            var ListOfStudents = JsonConvert.DeserializeObject<List<Object>>(lines);
            return ListOfStudents;
        }
    }
}
