namespace MaxLength_Colatz_Sequence
{
    internal class Program
    {
        static void Colatz(int n)
        {
            while (n > 1)
            {
                if (n % 2 != 0)
                {
                    n = 3 * n + 1;
                }
                else
                    n /= 2;
                Console.Write(n+" ");
            }
        }
        static int ColatzLength(int n)
        {
            int len=0;
            while (n > 1)
            {
                if (n % 2 != 0)
                {
                    n = n * 3 + 1;
                    len++;
                }
                else
                {
                    n /= 2;
                    len++;
                }
            }
            return len;
        }
        static void Main(string[] args)
        {
            int a, b, maxLength=1, length, maxNumber=1;
            a=int.Parse(Console.ReadLine());
            b=int.Parse(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                Colatz(i);
                Console.WriteLine();
                length = ColatzLength(i);
                if (length > maxLength)
                {
                    maxLength = length;
                    maxNumber = i;
                }
            }
            Console.WriteLine($"The number with the longest sequence is {maxNumber} with the length of {maxLength}");
        }
    }
}