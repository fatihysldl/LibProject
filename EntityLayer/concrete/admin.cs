using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.concrete
{
    public class admin
    {
        [Key]
        public int AdminId { get; set; }

        [StringLength(15)]
        public string AdminNick { get; set; }
        
        [StringLength(15)]
        public string AdminPassword { get; set; }

        [StringLength(300)]
        public string AdminMail { get; set; }
    }
}
