using System.ComponentModel.DataAnnotations;

namespace BMG_db.Models
{
    public class Branch
    {
        [Key]
        public string branch_id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string email { get; set; }

        public List<Employee>? employees { get; set; }
        public List<Customer>? customers { get; set; }

        public Branch()
        {
            this.employees = new List<Employee>();
            this.customers = new List<Customer>();
        }
        public Branch(string branch_id, string name, string address, string phone, string email)
        {
            this.branch_id = branch_id;
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.email = email;
            this.employees = new List<Employee>();
            this.customers = new List<Customer>();
        }
    }
}
