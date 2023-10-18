using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.concrete
{
    public class bookCategory
    {
        [Key]
        public int categoryId { get; set; }

        [StringLength(15)]
        public string category { get; set; }
    }
}
