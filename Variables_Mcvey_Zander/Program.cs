using System;

namespace Variables_Mcvey_Zander
{
    class Program
    {
        static void Main(string[] args)
        {  /*Integer and is labeled "favoriteNumber"*/
            int favoriteNumber;
            /*They will not be jumping or running through the text */
            bool isJumping = false, isRunning = false;
            /*myFloat is the floating point which is stated to be 89.12*/
            float myFloat;
            /*This is my favorite number, 7*/
            favoriteNumber = 7;
            /*Shows myFloat is the number 89.12 for this program */
            myFloat = 89.12f;
            /*The constant is finalGrade, which is a double for this program */
            const double finalGrade = 87.12;

            /*STOP READING ME MR.HOUSTON!*/

            /*Prints all the variables to console */
            Console.WriteLine("Favorite #: " + favoriteNumber);
            Console.WriteLine("Jumping: " + isJumping);
            Console.WriteLine("Running: " + isRunning);
            Console.WriteLine("Random Floating #: " + myFloat);
            Console.WriteLine("Final Grade " + finalGrade);

        }
    }
}
