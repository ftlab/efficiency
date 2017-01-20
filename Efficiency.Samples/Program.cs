using System;

namespace Efficiency.Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            var samples = new EffMatrixSamples();
            samples.Builder();

            Console.ReadKey();
        }
    }
}
