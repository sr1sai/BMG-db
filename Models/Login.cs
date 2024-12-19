using System.ComponentModel.DataAnnotations;

namespace BMG_db.Models
{
    public class Login
    {
        [Key]
        public string user_id { get; set; }
        public int clearence_level { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        public Login()
        {
        }
        public Login(string user_id,int clearence_level,string username,string password)
        {
            this.user_id = user_id;
            this.clearence_level = clearence_level;
            this.username = username;
            this.password = password;
        }

    }
}
