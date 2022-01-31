using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndcsvfile.Response
{
    public class CsvfileResponse
    {
        public Guid Id { get; set; }
        public int StudentNumber { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string CourseCode { get; set; }
        public string CourseDescription { get; set; }
        public string Grade { get; set; }
    }
}
