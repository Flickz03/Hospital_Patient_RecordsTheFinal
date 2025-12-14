
using SQLite;

namespace Hospital_Patient_Records
{
    public class Patient
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string MedicalHistory { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public string Birthday { get; set; }
        public string DoctorNote { get; set; }
        public string FitStatus { get; set; }
    }
}
