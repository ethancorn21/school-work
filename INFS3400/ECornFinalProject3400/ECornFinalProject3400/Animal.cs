using System.Collections.Generic;

/*
  Q1: abstract animal class means the Animal class cannot be instantiated directly, only extended.
  It acts as a blueprint for subclasses because they must implement SetUniqueValue and GetSubTypes before they can be used.
 */

namespace ECornFinalProject3400
{
    abstract public class Animal
    {
        public string Name { get; set; }
        public string Birthdate { get; set; }
        public string Description { get; set; }
        public string SubType { get; set; }

        abstract public void SetUniqueValue(bool unique_attribute);

        abstract public List<string> GetSubTypes();

        public override string ToString()
        {
            return $"{Name}, {Birthdate}, {Description}";
        }
    }
}
