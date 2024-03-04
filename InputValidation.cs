using System;
namespace UtilityForShape
{
    /// <summary>
    /// 
    /// </summary>
    public class InputValidation
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns></returns>
        public static double GetUserInput(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                if ((double.TryParse(Console.ReadLine(), out double value)) == false || value < 0)
                {
                    Console.WriteLine("Error!! Please enter valid value only !!");
                    Console.WriteLine("Please Re-enter value  : ");
                    continue;
                }
                return value;
            }
        }
    }
}
