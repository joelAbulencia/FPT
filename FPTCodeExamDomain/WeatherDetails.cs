using System;
using System.Collections.Generic;
using System.Text;

namespace FPTCodeExamDomain
{
    public class WeatherDetails
    {
        public Request request { get; set; }
        public Location location { get; set; }
        public Current current { get; set; }
    }
}
