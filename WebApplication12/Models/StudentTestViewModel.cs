﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication12.Models
{
    public class StudentTestViewModel
    {
        public IEnumerable<Object> students { get; set; }
        public IEnumerable<Test> tests { get; set; }

        public Student student { get; set; }
    }
}