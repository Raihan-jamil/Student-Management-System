using Newtonsoft.Json;
using StudentManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Model
{
    class SemesterModel
    {
        [JsonProperty]
        private string Year { get; set; }
        [JsonProperty]
        private SemesterName SemesterName{ get; set; }

        public SemesterModel(string Year, SemesterName SemesterName)
        {
            this.SemesterName = SemesterName;
            this.Year = Year;
        }
        public SemesterModel(string Year, string Name)
        {
            SemesterName sN;
            Enum.TryParse<SemesterName>(Name, out sN);
            this.SemesterName = sN;
            this.Year = Year;
        }
    }
}
