using StudentManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Services
{
    interface IStudentService
    {
        List<Object> viewAllStudents();
        void addStudent(StudentModel student);
        StudentModel singleStudent(string StudentId);
        void deleteStudents(string Id);
        void addNewSemester(int StudentId, SemesterModel semester);
    }
}
