namespace OOP.Samples.PolymorphismSamples
{
    public class CompileTimePolymorphism
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public int Add(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }

        public int Add(params int[] values)
        {
            if (values.Length < 1)
                return 0;

            int sum = 0;
            for(int i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }

            return sum;
        }
    }
}
