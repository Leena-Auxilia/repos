using System;

namespace ConsoleApp4
{

    class car
    {
       
        /// <summary>
        /// 
        /// </summary>
        public static void calculateArraySum()
        {
            int[] arr = { 1, 2, 3, 4 };
            int sum = 0;

            try
            {

                for (int i = 0; i < 5; i++)
                {

                    sum = sum + arr[i];
                }
            }
                       catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("From the generic exception block");
            }

            Console.WriteLine(sum);
        }

       
        public static void Main(string[] args)
        {
            calculateArraySum();
            
        }

    }
    
}
            




