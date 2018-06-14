using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Annotations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace English2._0
{
    public class Users
    {
        [Key]
        [Column("UserId")]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string level { get; set; }
        public List<UsersWords> UsersWord { get; set; }
        public List<Play> Play1 { get; set; }
        public List<Play> Play2 { get; set; }

        public static string aktivePlyer;
    }
}
