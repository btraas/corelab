﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace corelab.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string School { get; set; }
        public DateTime StartDate { get; set; }
    }
}
