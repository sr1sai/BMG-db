using System.ComponentModel.DataAnnotations;

namespace BMG_db.Models
{
    public class Loan
    {
        [Key]
        public string loan_id { get; set; }
        public string credit_account_id { get; set; }
        public decimal amount { get; set; }
        public double roi { get; set; }
        public int allocated_months { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Loan()
        {
        }
        public Loan(string loan_id, string credit_account_id, decimal amount, double roi, int allocated_months, DateTime StartDate, DateTime EndDate)
        {
            this.loan_id = loan_id;
            this.credit_account_id = credit_account_id;
            this.amount = amount;
            this.roi = roi;
            this.allocated_months = allocated_months;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
        }
    }
}
