using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ResumeGenerator.Domain.Enums
{
    public enum RefListRace
    {
        [Description("Black")]
        Black = 1,

        [Description("Coloured")]
        Coloured = 2,

        [Description("White")]
        White = 3,

        [Description("Indian")]
        Indian = 4,

        [Description("Hispanic")]
        Hispanic = 5,

        [Description("Asian")]
        Asian = 6,

        [Description("Other")]
        Other = 7,
    }
}
