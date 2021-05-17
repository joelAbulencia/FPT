using System;
using System.Collections.Generic;
using System.Text;

namespace FPTCodeExamDomain
{
    public class UserAnswers
    {
        public UserAnswers()
        {
            AbleToGoOutside = true;
            ShouldWearSunscreen = false;
            AbleToFlyKite = true;
        }
        public bool AbleToGoOutside { get; set; }
        public bool ShouldWearSunscreen { get; set; }
        public bool AbleToFlyKite { get; set; }
    }
}
