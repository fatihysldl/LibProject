﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.concrete
{
    public class borrowedBook
    {
        [Key]
        public int Id { get; set; }
        public int memberId { get; set; }
        public int categoryId { get; set; }
        public int bookId { get; set; }
        public member member{ get; set; }
        public book book{ get; set; }
        public bookCategory category { get; set; }
    }
}
