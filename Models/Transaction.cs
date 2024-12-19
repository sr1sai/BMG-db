using System.ComponentModel.DataAnnotations;

namespace BMG_db.Models
{
    public class Transaction
    {
        [Key]
        public string transaction_id { get; set; }
        public string type { get; set; }
        public double amount { get; set; }
        public DateTime date { get; set; }
        public string sender_id { get; set; }
        public string receiver_id { get; set; }

        public Transaction()
        {
        }
        public Transaction(string transaction_id, string type, double amount, DateTime date, string sender_id, string receiver_id)
        {
            this.transaction_id = transaction_id;
            this.type = type;
            this.amount = amount;
            this.date = date;
            this.sender_id = sender_id;
            this.receiver_id = receiver_id;
        }
    }
}
