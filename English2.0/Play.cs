using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace English2._0
{
    public class Play
    {
        [ForeignKey("Users")]
        public int FirstId { get; set; }
        public Users User1 { get; set; }

        [ForeignKey("Users")]
        public int SecondId { get; set; }
        public Users User2 { get; set; }

        public bool Start { get; set; }

        public DateTime Date { get; set; }

        public int Result { get; set; }

    }
}
