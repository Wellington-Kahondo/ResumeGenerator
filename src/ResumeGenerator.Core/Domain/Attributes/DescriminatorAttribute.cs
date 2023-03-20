using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeGenerator.Domain.Attributes
{
    internal class DescriminatorAttribute : Attribute
    {
        /// <summary>
        /// name of the descriminator column
        /// </summary>
        public string DiscriminatorColumn { get; set; }
        /// <summary>
        /// If true, indicates that entity uses descriminator
        /// </summary>

        public bool UseDescriminator { get; set; }
        /// <summary>
        /// if true, indicates that the ORM should filter out rows with unknown descriminator values
        /// </summary>

        public bool FilterUnknokwnDescriminators { get; set; }

        public DescriminatorAttribute()
        {
            DiscriminatorColumn = "Person_Descrimanator";
            UseDescriminator = true;
            FilterUnknokwnDescriminators = false;
        }
    }
}
