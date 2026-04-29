using System.Collections.Generic;

namespace ECornFinalProject3400
{
    public class Fish : Animal
    {
        private List<string> subtypes;
        private bool scales;

        public Fish()
        {
            this.subtypes = new List<string> { "Goldfish", "Trout", "Salmon" };
        }

        public Fish(List<string> types)
        {
            this.subtypes = types;
        }

        public override void SetUniqueValue(bool unique_attribute)
        {
            this.scales = unique_attribute;
        }

        public override List<string> GetSubTypes()
        {
            return this.subtypes;
        }

        public override string ToString()
        {
            return "Name: " + Name + " Type:" + SubType + " DOB:" + Birthdate
                + " Scales?: " + this.scales + " Description: " + this.Description;
        }
    }
}
