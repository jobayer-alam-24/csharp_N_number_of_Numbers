namespace csharp_N_number_of_Numbers
{
    //Program to find sum of n numbers
    class Program
    {
        static void Main(string[] args)
        {
            NOfEven(10);
            NOfOdd(10);
            NOfPrime(10);
            SumOfNOfPrime(10);
            SumOfNOfEven(10);
            SumOfNOfOdd(10);
        }
        public static void NOfEven(int n)
        {
            int counter = 0, start = 2;
            while (counter < n)
            {
                if (start % 2 == 0)
                {
                    Console.Write($"{start} ");
                    counter++;
                }
                start++;
            }
            Console.WriteLine();
        }
        public static void NOfOdd(int n)
        {
            int counter = 0, start = 1;
            while (counter < n)
            {
                if (start % 2 == 1)
                {
                    Console.Write($"{start} ");
                    counter++;
                }
                start++;
            }
            Console.WriteLine();
        }
        public static void NOfPrime(int n)
        {
            int counter = 0, start = 2;
        
            while(counter < n)
            {
                if(IsPrime(start))
                {
                    Console.Write($"{start} ");
                    counter++;
                }
                start++;
            }
            Console.WriteLine();
        }
        public static void  SumOfNOfPrime(int n)
        {
            int counter = 0, sum = 0, start = 2;
            while(counter < n)
            {
                if(IsPrime(start))
                {
                    sum += start;
                    counter++;
                }
                start++;
            }
            Console.WriteLine($"Sum Of Prime: {sum}");
        }
        public static void SumOfNOfEven(int n)
        {
            int counter = 0, sum = 0, start = 2;
            while (counter < n)
            {
                if (start % 2 == 0)
                {
                    sum += start;
                    counter++;
                }
                start++;
            }
            Console.Write($"Sum of EVEN: {sum}\n");
        }
        public static void SumOfNOfOdd(int n)
        {
            int counter = 0, sum = 0, start = 1;
            while (counter < n)
            {
                if (start % 2 == 1)
                {
                    sum += start;
                    counter++;
                }
                start++;
            }
            Console.WriteLine($"Sum of ODD: {sum}\n");
        }

        // *==================Prime check============*
        public static bool IsPrime(int number)
        {
            int count = 0;
            if (number > 1)
            {
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        count++;
                        break;
                    }
                }
                if(count > 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

    }
}
