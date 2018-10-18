using System;

namespace ExampleAttributes.Attributes
{
    
    public class DisplayNameAttribute : Attribute
    {
        public readonly string DisplayName;

        //constructor
        public DisplayNameAttribute(string displayName)
        {
            DisplayName = displayName;
        }
    }
}