using System;


namespace BerekeningTarief
{

    class Program
    {
        static void Main()
        {
            int leeftijd;
            bool aanmerking;


            Console.Write($"Geef je leeftijd: ");
            leeftijd = int.Parse(Console.ReadLine());

            // Leeftijd moet kleiner of groter zijn dan 65+ om toegelaten te worden
            aanmerking = leeftijd <= 18 || leeftijd >= 65;
            Console.WriteLine($"Korting door leeftijd < 18 of > 65: {aanmerking}");
        }
    }
}



