﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessFramework.Dao.Subjects
{
    public class SubjectDao
    {
        internal SubjectDao()
        {

        }

        public int Id { get; }
        public string Name { get; set; }
    }
}
