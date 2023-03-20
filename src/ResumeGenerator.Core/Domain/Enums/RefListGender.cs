using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ResumeGenerator.Domain.Enums
{
    public enum RefListGender
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("Male")]
        Male = 1,
        /// <summary>
        /// 
        /// </summary>    
        [Description("Female")]
        Female = 2,

        [Description("Unkown")]
        NotDisclosed = 0
    }
}
