using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ResumeGenerator.Domain.Enums
{
    public enum RefListTitle
    {
        [Description("MR")]
        MR = 1,

        [Description("MRS")]
        MRS = 2,

        [Description("MISS")]
        MISS = 3,

        [Description("Other")]
        Other = 4,
    }
}
