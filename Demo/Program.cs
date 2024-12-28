using System.Linq.Expressions;
using Common;

namespace Demo
{
    internal class Program
    {
        public static void DoSomeCode()
        {
            try
            {
                int X, Y, Z;
                X = int.Parse(Console.ReadLine()); // FormatException
                Y = int.Parse(Console.ReadLine());
                Z = X / Y; // DivideByZeroException

                int[] Numbers = { 1, 2, 3 };
                Numbers[10] = 100; // IndexOutOfRangeException
            }
            // CLR Create Object From Exception
            catch (Exception ex)
            {
                // log file
                //Stored in DB
                Console.WriteLine(ex.Message);
            }
            //catch(DivideByZeroException ex) {
            //    Console.WriteLine(ex.Message);
            //}
        }

        public static void DoSomeProtictiveCode()
        {
            try
            {
                int X, Y, Z;
                bool Flag;

                // X = int.Parse(Console.ReadLine()); // FormatException
                do
                {
                    Console.WriteLine("Enter First Number");
                    Flag = int.TryParse(Console.ReadLine(), out X);
                } while (!Flag);

                // Y = int.Parse(Console.ReadLine());
                do
                {
                    Console.WriteLine("Enter Second Number");
                    Flag = int.TryParse(Console.ReadLine(), out Y);
                } while (!Flag || Y == 0);
                Z = X / Y; // DivideByZeroException

                int[] Numbers = null;
                if (Numbers?.Length > 10) { Numbers[10] = 100; }// IndexOutOfRangeException
            }
            // CLR Create Object From Exception
            catch (Exception ex)
            {
                // log file
                //Stored in DB
                Console.WriteLine(ex.Message);
            }
        }

        static void Main(string[] args)
        {
            #region Exception Handle
            //DoSomeCode();

            //Exception
            //SystemException
            //FormatException
            //DivideByZeroException

            //Exceptions
            // 1. System Exceptions
            // 1.1 Format Exception
            // 1.2 Index Out Of Range Exception
            // 1.3 Null Reference Exception
            // 1.4 Invalid Operation Exception
            // 1.5 Arithmetic Exception
            // 1.5.1 Divided By Zero Exception
            // 1.5.2 Overflow Exception
            // 2. Application Exception

            //try
            //    { DoSomeProtictiveCode();
            //    throw new Exception() }
            //catch(Exception ex)
            //    { Console.WriteLine(ex.Message); } 
            //finally{
            //    // Close - free - Delete - Dealocate unmanaged  Resources
            //    // Open File
            //    // Open connection Database
            //    //x=10
            //    Console.WriteLine("Finally");
            //}
            //Console.WriteLine("After Try Catch");
            #endregion

            #region Access Modifier
           // TypeA typea = new TypeA();
            //typea.x = 10;
            //typea.y = 10;
            //typea.z = 10;
            #endregion


        }
    }
}
