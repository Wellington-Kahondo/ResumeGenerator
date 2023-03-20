using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeGenerator.Domain.Attributes
{
    public class DescriminatorValue : Attribute
    {
        public object Value { get; set; }

        public DescriminatorValue(object value)
        {
            Value = value;
        }
    }
}
