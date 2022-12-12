using System.Diagnostics.Contracts;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrinhQuangMinhBTH2.Models
{
    public class Student
    {
        public string StudentID { get; set;}
        public string StudentName { get; set;}
        public string FacultyID { get; set;}
        [ForeignKey("FacultyID")]
        public Faculty? Faculty {get; set; }
    }
}