using System.ComponentModel.DataAnnotations;

namespace web_app_users.Models
{
    public class Class
    {
        public String ID { get; set; }
        public String Name { get; set; }
        public String LastName { get; set; }

        [DataType(DataType.Date)]
        public DateTime BornDate { get; set; }
        public String Password { get; set; }
    }
}
