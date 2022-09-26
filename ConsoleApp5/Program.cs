namespace ConsoleApp5
{
    internal class myProgram
    {
        
        public void calculateSum()
        {
            int[] arr = { 1, 2, 4, 5 };
            int sum = 0;
            try
            {
                for (int i = 0; i < 4; i++)
                {
                    sum = sum + arr[i];
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("inside the specific block");
            }
            /*catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("inside the generic block");
            }*/
            finally
            { Console.WriteLine("in the finally block"); }


            Console.WriteLine(sum);
        }
        /*static void Main(string[] args)
        {
            calculateSum();
        }*/
    }
}