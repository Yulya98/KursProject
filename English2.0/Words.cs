using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace English2._0
{

    public class Words
    {
        [Key]
        [Column("WordId")]
        public int WordId { get; set; }
        public string Word { get; set; }
        public string Translate { get; set; }
        public string Url_Image { get; set; }
        public List<UsersWords> UsersWord { get; set; }
    }
}
