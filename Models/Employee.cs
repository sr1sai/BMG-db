using System.ComponentModel.DataAnnotations;

namespace BMG_db.Models
{
    public class Employee
    {
        [Key]
        public string employee_id { get; set; }
        public string designation { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public DateTime dob { get; set; }
        public DateTime doj { get; set; }

        public Employee()
        {
        }
        public Employee(string employee_id, string designation, string name, string address, string phone, string email, DateTime dob, DateTime doj)
        {
            this.employee_id = employee_id;
            this.designation = designation;
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.email = email;
            this.dob = dob;
            this.doj = doj;
        }
    }
}
