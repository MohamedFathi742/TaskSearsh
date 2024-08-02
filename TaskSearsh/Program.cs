namespace TaskSearsh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Plesse enter list fo numbers separated by comma ");
                string input = Console.ReadLine();

                string[] numbers = input.Split(" , " );

                int num = 0;
                foreach (var item in numbers)
                {
                    num=int.Parse(item);
                    //if ( num==  ) { 
                    
                    
                    
                    
                    //}
                    
                        
                    
                }
                throw new Exception("Plesse enter unduplicate numbers ");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error : {ex.Message}");

            }

            finally {

                Console.WriteLine(" you're Finished");

            }
        }

    }
}


