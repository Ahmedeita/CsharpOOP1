using System;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            /*
             * 1.Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members.
             * Then, write a C# program that prints out all the days of the week using this enum */

            foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine(day);
            }

            //**********************************************************
            //                    Another Solution
            //**********************************************************

            for (int  i = 0;  i < 7;  i++)              
                Console.WriteLine((WeekDays)i);


            #endregion

            
        }
    }
}
