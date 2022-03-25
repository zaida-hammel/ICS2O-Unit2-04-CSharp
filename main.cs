// Created by: Zaida Hammel
// Created on: March 2022
//
// This program accepts user input.

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function states the area and perimeter of a rectangle
        int length, width, area, perimeter;

            Console.WriteLine("This program calculates the area and perimeter of a rectangle.");
            Console.Write("Enter the length (mm): ");
            length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the width (mm): ");

            width = Convert.ToInt32(Console.ReadLine());
            area = length * width;
            perimeter = 2 * (length + width);


            Console.WriteLine("The area is: " + area + "mm².");
            Console.WriteLine("The perimeter is: " + perimeter + "mm.");
            Console.ReadKey();

            Console.WriteLine("\nDone.");
    }
}