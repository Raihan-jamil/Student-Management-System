using Newtonsoft.Json;
using StudentManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Model
{
    class StudentModel
    {
        [JsonProperty]
        private string FirstName { get; set; }
        [JsonProperty]
        private string MiddleName { get; set; }
        [JsonProperty]
        private string LastName { get; set; }
        [JsonProperty]
        public string StudentId { get; set; }
        [JsonProperty]
        private SemesterModel JoiningBatch { get; set; }
        [JsonProperty]
        private Department department { get; set; }
        [JsonProperty]
        private Degree degree { get; set; }
        [JsonProperty]
        private List<SemesterModel> ListOfemesters { get; set; }
        [JsonProperty]
        private List<CourseModel> ListOfCourses { get; set; }


        public StudentModel(string FirstName,
                            string MiddleName,
                            string LastName,
                            string StudentId,
                            SemesterModel JoiningBatch,
                            Department department,
                            Degree degree,
                            List<SemesterModel> ListOfSemesters,
                            List<CourseModel> ListOfCourses)
        {
            this.FirstName = FirstName;
            this.MiddleName = MiddleName;
            this.LastName = LastName;
            this.StudentId = StudentId;
            this.JoiningBatch = JoiningBatch;
            this.department = department;
            this.degree = degree;
            this.ListOfemesters = ListOfSemesters;
            this.ListOfCourses = ListOfCourses;
        }
    }
}
