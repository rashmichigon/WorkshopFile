namespace WorkshopFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 1, a = 0;
            for (int i=1;i <=n;i++)
            {
                if(n % i == 0)
                {
                    a++;
                    if (a == 2)
                    {
                        Console.WriteLine("n is a prime number");

                    }
                    else
                    {
                        Console.WriteLine("Not a prime number");
                    }
                }
                
                Console.ReadLine();
            }
        }
    }
}