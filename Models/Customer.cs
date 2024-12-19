using System.ComponentModel.DataAnnotations;

namespace BMG_db.Models
{
    public class Customer
    {
        [Key]
        public string customer_id { get; set; }
        public string name { get; set; }
        public string? address { get; set; }
        public string phone { get; set; }
        public string? email { get; set; }
        public DateTime? dob { get; set; }

        public List<Account>? accounts { get; set; }
        public List<Loan>? loans { get; set; }
        public List<Locker>? lockers { get; set; }

        public Customer()
        {
            this.accounts = new List<Account>();
            this.loans = new List<Loan>();
            this.lockers = new List<Locker>();
        }
        public Customer(string customer_id, string name, string address, string phone, string email, DateTime dob)
        {
            this.customer_id = customer_id;
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.email = email;
            this.dob = dob;
            this.accounts = new List<Account>();
            this.loans = new List<Loan>();
            this.lockers = new List<Locker>();
        }
    }
}
