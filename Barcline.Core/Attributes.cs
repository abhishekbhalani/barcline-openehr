using System;

namespace Barcline.Core
{
    [AttributeUsage(AttributeTargets.Property)]
    public class MinOccursAttribute : Attribute
    {
        public String Value { get; set; }

        public MinOccursAttribute(String value)
        {
            this.Value = value;
        }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class MaxOccursAttribute : Attribute
    {
        public String Value { get; set; }

        public MaxOccursAttribute(String value)
        {
            this.Value = value;
        }
    }
}