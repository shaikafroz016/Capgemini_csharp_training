﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webappwithdbs.Models
{
    public class Employe
    {
        public int empno { get; set; }
        public string empname { get; set; }
        public string job { get; set; }
        public int deptno { get; set; }
        public int salary { get; set; }
    }
}
