using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ResumeGenerator.Domain.Enums
{
    public enum RefListSection
    {
        [Description("Education")]
        Education =1,

        [Description("Certifications")]
        Certification =2,

        [Description("WorkExperience")]
        WorkExperience = 3,

        [Description("Skills")]
        Skill =4,


        [Description("Profile")]
        Profile = 5,

        //[Description("Picture")]
        //StoredFile = 6,


    }
}
