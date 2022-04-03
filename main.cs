// Created by: Joanne Santhosh
// Created on: Mar 2022
//
// This program calculates the area of a trapezoid

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This program calculates the area of a trapezoid
        int aBaseOfTrapezoid;
        int bBaseOfTrapezoid;
        int heightOfTrapezoid;
        Console.WriteLine("This program calculates the area of a trapezoid");
        Console.WriteLine("");

        Console.WriteLine("Enter the a base of the trapezoid.");
        aBaseOfTrapezoid = (Convert.ToInt32(Console.ReadLine()));
        Console.Write("Enter the b base of the trapezoid. ");
        bBaseOfTrapezoid =(Convert.ToInt32(Console.ReadLine()));
        Console.Write("Enter the height of the trapezoid. ");
        heightOfTrapezoid =(Convert.ToInt32(Console.ReadLine()));

        Console.WriteLine("");
        Console.WriteLine("The Area of the trapezoid is: " + heightOfTrapezoid *(aBaseOfTrapezoid + bBaseOfTrapezoid / 2));

        Console.WriteLine("\nDone.");
    }
}