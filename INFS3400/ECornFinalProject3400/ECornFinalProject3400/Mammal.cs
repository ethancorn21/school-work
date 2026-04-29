using System.Collections.Generic;

namespace ECornFinalProject3400
{
    public class Mammal : Animal
    {
        private List<string> subtypes;
        private bool fur;

        public Mammal()
        {
            this.subtypes = new List<string> { "Dog", "Cat", "Hamster" };
        }

        public Mammal(List<string> types)
        {
            this.subtypes = types;
        }

        public override void SetUniqueValue(bool unique_attribute)
        {
            this.fur = unique_attribute;
        }

        public override List<string> GetSubTypes()
        {
            return this.subtypes;
        }

        public override string ToString()
        {
            return "Name: " + Name + " Type:" + SubType + " DOB:" + Birthdate
                + " Fur?: " + this.fur + " Description: " + this.Description;
        }
    }
}
