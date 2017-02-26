using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Core
{
    public enum Card
    {
        [Description("Rock")]
        R = 1,
        [Description("Paper")]
        P = 2,
        [Description("Scissors")]
        S = 3
    }
}
