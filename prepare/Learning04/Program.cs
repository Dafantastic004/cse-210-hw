
using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment DestinyMath = new MathAssignment("Momoh Destiny", "Math 215","Section 7","Problem 7-21");
        WrittingAssignment JakeWritting = new WrittingAssignment("Momoh Detiny", "ENG 105", "The Pros and Cons of Tobacco");
        Console.WriteLine(JakeMath.getSummary());
        Console.WriteLine(JakeMath.getMathHomeWork());
        Console.WriteLine(JakeWritting.getSummary());
        Console.WriteLine(JakeWritting.getWrittingInformation());
    }
}
