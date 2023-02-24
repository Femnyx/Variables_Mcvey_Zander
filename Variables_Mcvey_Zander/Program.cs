using System;

namespace Variables_Mcvey_Zander
{
    class Program
    {
        static void Main(string[] args)
        {
            int favoriteNumber;
            bool isJumping = false, isRunning = false;
            float myFloat;
            favoriteNumber = 7;
            myFloat = 89.12f;
            const double finalGrade = 87.12;

            Console.WriteLine($"The lucky number is {favoriteNumber}");
            Console.WriteLine($"it's {isJumping}");
            Console.WriteLine($"it is not {isRunning}!");
            Console.WriteLine($"i'm not! 2 years ago it was {myFloat}!");
            Console.WriteLine($"first off that is the wrong number and second my favorite number back then was {finalGrade}!");

        }
    }
}
