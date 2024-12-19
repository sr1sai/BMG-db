using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BMG_db.Models
{
    public class Account
    {
        [Key]
        public string account_id { get; set; }
        public string type { get; set; }
        public double balance { get; set; }
        public double interest_rate { get; set; }
        public DateTime? open_date { get; set; }
        public DateTime? close_date { get; set; }
        public List<Transaction>? transactions { get; set; }

        public Account()
        {
            this.transactions = new List<Transaction>();
        }

        // Constructor with parameters
        public Account(string account_id, string type, double balance, double interest_rate, DateTime? open_date, DateTime? close_date)
        {
            this.account_id = account_id;
            this.type = type;
            this.balance = balance;
            this.interest_rate = interest_rate;
            this.open_date = open_date;
            this.close_date = close_date;
            this.transactions = new List<Transaction>();
        }
    }
}
