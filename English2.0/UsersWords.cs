using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace English2._0
{
    public class UsersWords
    {
        [ForeignKey("Users")]
        public int UserId { get; set; }
        public Users User { get; set; }

        [ForeignKey("Words")]
        public int WordId { get; set; }
        public Words Word { get; set; }

        public bool flag { get; set; }

        public bool flagForPlay { get; set; }
    }
}
