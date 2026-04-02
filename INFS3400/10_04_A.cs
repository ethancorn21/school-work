/*
Declare CookieOrder class
Should include the following auto-implemented properties
OrderNum
Name
CookieType

Should incude the following fields
Dozens - # of dozens ordered
Price - $15 per dozen for first 2 dozen, $13 per after

child class : SpecialCookieOrder
SpecialDescription
overrides Price - $10 for special handling up to $40, $8 for higher-priced orders afterwards
*/

using System;
using static System.Console;
using System.Globalization;
class CookieDemo
{
    static void Main()
    {
		CookieOrder plainOrder = new CookieOrder();
        plainOrder.Dozens = 3;
        plainOrder.OrderNum = "1";
        plainOrder.Name = "John";
        plainOrder.CookieType = "Chocolate Chip";
		Console.WriteLine("Order #{0}      {1}",plainOrder.OrderNum, plainOrder.Name);
		Console.WriteLine("   type: {0}", plainOrder.CookieType);
		Console.WriteLine("   {0} dozen --- ${1}", plainOrder.Dozens, plainOrder.Price);

		SpecialCookieOrder special = new SpecialCookieOrder();
		special.SpecialDescription = "gluten-free";
        special.Dozens = 1;
        special.OrderNum = "2";
        special.Name = "Arthur";
        special.CookieType = "Chocolate Chip";
		Console.WriteLine("Order #{0}      {1}", special.OrderNum, special.Name);
		Console.WriteLine("   type: {0} {1}", special.SpecialDescription, special.CookieType);
		Console.WriteLine("   {0} dozen --- ${1}", special.Dozens, special.Price);

    }
}

class CookieOrder
{
    public double Price;
    private int dozens;
    public virtual int Dozens
    {
        get
        {
            return dozens;
        }
        set
        {
            dozens = value;
            if (dozens <= 2)
            {
                Price = 15 * dozens;
            }
            else
            {
                Price = 30 + (13 * (dozens - 2));
            }
        }
    }

    public string OrderNum { get; set; }
    public string Name { get; set; }
    public string CookieType { get; set; }
}

/*
child class : SpecialCookieOrder
SpecialDescription
overrides Price - $10 for special handling up to $40, $8 for higher-priced orders afterwards
*/
class SpecialCookieOrder : CookieOrder
{
    public string SpecialDescription;
    public override int Dozens
    {
        get
        {
            return base.Dozens;
        }
        set
        {
            base.Dozens = value;
            double handling;
            if (Price <= 40)
            {
                handling = 10;
            }
            else
            {
                handling = 8;
            }
            Price += handling;
        }
    }
}