using System;
using static System.Console;
using System.Globalization;
using System.Runtime.ConstrainedExecution;
class LetterDemo
{
    static void Main()
    {
//Letter To: Electric Company Date mailed : 02/14/18
//CertifiedLetter To: Howe and Morris, LLC Date mailed : 04/01/2019 Tracking number: i2YD45
 
        Letter letter = new Letter();
        CertifiedLetter certifiedLetter = new CertifiedLetter();

        letter.Date = "02/14/18";
        letter.Name = "Electric Company";
        WriteLine(letter.ToString());

        certifiedLetter.Name = "Howe and Morris";
        certifiedLetter.Date = "04/01/2019";
        certifiedLetter.TrackingNumber = "123456";
        WriteLine(certifiedLetter.ToString()); 
    }

}

class Letter
{
    public string Name { get; set; }
    public string Date { get; set; }
    public override string ToString()
    {
        return $"{GetType()} To: {Name}, LLC Date mailed : {Date}";
    }
}

class CertifiedLetter : Letter
{
    public string TrackingNumber { get; set; }

    public override ToString() {
        return $"{GetType()} To: {Name}, LLC Date mailed : {Date} Tracking number: {TrackingNumber}";
    } 
}