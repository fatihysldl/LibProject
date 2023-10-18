using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.concrete
{
    public class member
    {
        [Key]
        public int memberId { get; set; }

        [StringLength(15)]
        public string memberName { get; set; }

        [StringLength(15)]

        public string memberSurname { get; set; }

        [StringLength(11)]
        public string memberPhone { get; set; }
    }
}
