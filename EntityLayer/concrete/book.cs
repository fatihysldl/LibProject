using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.concrete
{
    public class book
    {
        [Key]
        public int bookId { get; set; }

        [StringLength(15)]
        public string bookName { get; set; }
        public int bookStock { get; set; }
        public int categoryId { get; set; }
        public bookCategory category { get; set; }
    }
}
