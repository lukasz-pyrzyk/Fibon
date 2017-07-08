namespace Fibon.Service
{
    public interface ICalculator
    {
        int Fib(int n);
    }

    public class FastOne : ICalculator
    {
        public int Fib(int n)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b += temp;
            }

            return a;
        }
    }
}
