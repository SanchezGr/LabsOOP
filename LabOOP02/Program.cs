using System;

namespace Lab2
{
    public sealed class GeometricProgression
    {
        private double _a0;
        private double _q;
        private int _n;

        public GeometricProgression(double a0, double q, int n)
        {
            _a0 = a0;
            _q  = q;
            _n  = n;
        }

        public static GeometricProgression ReadFromConsole()
        {
            Console.Write("a0 = ");
            double a0 = double.Parse(Console.ReadLine()!);
            Console.Write("q  = ");
            double q  = double.Parse(Console.ReadLine()!);
            Console.Write("n  = ");
            int n     = int.Parse(Console.ReadLine()!);
            return new GeometricProgression(a0, q, n);
        }

        public double LastTerm() => _a0 * Math.Pow(_q, _n - 1);

        public bool IsLastMax()
        {
            double max = _a0;
            double term = _a0;
            for (int i = 2; i <= _n; i++)
            {
                term *= _q;
                if (term > max) max = term;
            }
            return Math.Abs(LastTerm() - max) < 1e-9;
        }
    }

    internal static class Program
    {
        private static void Main()
        {
            var gp = GeometricProgression.ReadFromConsole();
            Console.WriteLine($"a_n = {gp.LastTerm()}");
            Console.WriteLine(gp.IsLastMax() ? "Останній є найбільшим" : "Останній не є найбільшим");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}