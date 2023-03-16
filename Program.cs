namespace Mud 
{
    class Program
    {
        static void Main(string[] args)
        {

            Parser parser = new Parser();

            Console.Write("Hello, world!\n> ");

            string? input = Console.ReadLine();
            List<string> tokens = new List<string>();
            
            if (input != null)
            {
                tokens = parser.Tokenize(input);
            }
        }
    }
}