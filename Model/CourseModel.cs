using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Model
{
    class CourseModel
    {
        private string year;
        private string semestername;

        [JsonProperty]
        private string CourseId { get; set; }
        [JsonProperty]
        private string CourseName { get; set; }
        [JsonProperty]
        private string InstructorName { get; set; }
        [JsonProperty]
        private int numberOfCredits { get; set; }

        public CourseModel(string CourseId, string CourseName, string InstructorName, int numberOfCredits)
        {
            this.CourseId = CourseId;
            this.CourseName = CourseName;
            this.InstructorName = InstructorName;
            this.numberOfCredits = numberOfCredits;
        }

        public CourseModel()
        {
        }
    }
}
