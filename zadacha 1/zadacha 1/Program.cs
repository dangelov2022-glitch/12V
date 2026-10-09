namespace zadacha_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            if (num < 100)
            {
                Console.WriteLine("less than 100");
            }
            else if (num >100&& num < 200)
            {
                Console.WriteLine("between 100 and 200");
            }
            else if (num > 200)
            {
                Console.WriteLine("Over 200");
            }

        }
    }
}
