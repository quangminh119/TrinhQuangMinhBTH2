using System.ComponentModel.DataAnnotations;

namespace TrinhQuangMinhBTH2.Modles

{
    public class Faculty
    {
        [Key]
        public string FacultyID{ get; set; }
        public string FacultyName{ get; set; }
    }
}