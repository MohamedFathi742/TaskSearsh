namespace StringSearch
{
    internal class Program
    {

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Plesse enter string");
                string strings = Console.ReadLine();
                if (strings != "i,o,u,e,a")

                    throw new Exception("string does not contain vowels.");

            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error: {ex.Message}");

            }
            finally {
                Console.WriteLine(" you're Finished");

            }



        }
        }
    }

