﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FPTCodeExamDomain
{
    public class Request
    {
        public string type { get; set; }
        public string query { get; set; }
        public string language { get; set; }
        public string unit { get; set; }
    }
}
