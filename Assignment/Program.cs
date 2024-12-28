using System;
using System.Data.SqlTypes;
using System.Globalization;


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

            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}

            ////**********************************************************
            ////                    Another Solution
            ////**********************************************************

            //for (int  i = 0;  i < 7;  i++)              
            //    Console.WriteLine((WeekDays)i);


            #endregion

            #region Q2
            /*2.Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members.
             * Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)*/



            //bool Flag = false;
            //Season SeasonName;
            //do
            //{
            //    Console.Write("Enter Season Name : ");
            //    Flag = Enum.TryParse(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Console.ReadLine()), out SeasonName);


            //}
            //while (!Flag);

            //switch (SeasonName)
            //{
            //    case Season.Spring:
            //        Console.WriteLine("march to may");
            //        break;
            //    case Season.Summer:
            //        Console.WriteLine("june to august"); break;
            //    case Season.Autumn:
            //        Console.WriteLine("September to November"); break;
            //    case Season.Winter:
            //        Console.WriteLine("December to February"); break;
            //    default:
            //        Console.WriteLine("Invalid input !!!"); break;
            //}

            #endregion

            #region Q3
            /*3.Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
            ⮚Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable*/

            //Permissions permission;
            //Permissions OldPermissions = (Permissions)7;
            //bool Flag = false;

            //do
            //{
            //    Console.Write("Enter the Permission that You want To Add or Remove : ");
            //    Flag = Enum.TryParse(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Console.ReadLine()), out permission);
            //}
            //while (!Flag);

            //if ((OldPermissions & permission) == permission)
            //{
            //    OldPermissions |=  permission;  
            //    Console.WriteLine($"You Now Removed  {permission} Permission because it's already existed before ");
            //}

            //else
            //{
            //    OldPermissions ^= permission;
            //    Console.WriteLine($"You added {permission} Permission");
            //}


            #endregion

            #region Q4
            /*4.Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members.
             * Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.*/

            #endregion
        }
    }
}
