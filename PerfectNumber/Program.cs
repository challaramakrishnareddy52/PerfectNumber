namespace PerfectNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, i, sum = 0;
            Console.WriteLine("Enter a number:");
            i = 1;
            number=int.Parse(Console.ReadLine());
            while(i<number)
            {
                if(number % i == 0)
                    sum+= i;
                i++;
            }
            if (sum == number)
                Console.WriteLine("it is a perfect number", number);
            else
                Console.WriteLine("it is not a perfect number", number);
        }
    }
}