using System;
using System.Collections.Generic;
using System.Text;

namespace FPTCodeExamDomain
{
    public class Timezone
    {
        public string timezone_identifier { get; set; }
        public string timezone_abbr { get; set; }
        public int utc_offset_sec { get; set; }
        public string is_dst { get; set; }
    }
}
