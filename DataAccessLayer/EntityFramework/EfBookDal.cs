﻿using DataAccessLayer.abstracts;
using DataAccessLayer.concrete;
using DataAccessLayer.concrete.repositories;
using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfBookDal : genericRepositoryDal<book>, IBookDal
    {
        public EfBookDal(context context) : base(context)
        {
        }
    }
}