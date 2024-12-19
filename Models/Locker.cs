using System.ComponentModel.DataAnnotations;

namespace BMG_db.Models
{
    public class Locker
    {
        [Key]
        public string locker_id { get; set; }
        public string type { get; set; }
        public string status { get; set; }
        public string? key { get; set; }
        public float? rent { get; set; }
        public DateTime? start_date { get; set; }

        public Locker()
        {
        }
        public Locker(string locker_id, string type, string status, string key, float rent, DateTime start_date)
        {
            this.locker_id = locker_id;
            this.type = type;
            this.status = status;
            this.key = key;
            this.rent = rent;
            this.start_date = DateTime.Now;
        }
    }
}
