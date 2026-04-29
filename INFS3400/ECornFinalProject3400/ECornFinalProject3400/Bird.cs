using System.Collections.Generic;

namespace ECornFinalProject3400
{
    public class Bird : Animal
    {
        private List<string> subtypes;
        private bool feathers;

        public Bird()
        {
            this.subtypes = new List<string> { "Robin", "Eagle", "Parrot" };
        }

        public Bird(List<string> types)
        {
            this.subtypes = types;
        }

        public override void SetUniqueValue(bool unique_attribute)
        {
            this.feathers = unique_attribute;
        }

        public override List<string> GetSubTypes()
        {
            return this.subtypes;
        }

        public override string ToString()
        {
            return "Name: " + Name + " Type:" + SubType + " DOB:" + Birthdate
                + " Feathers?: " + this.feathers + " Description: " + this.Description;
        }
    }
}
