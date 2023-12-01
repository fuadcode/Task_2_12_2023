

namespace Homework_2_12_2023.Helpers
{
    public class Celsius
    {
        public int Degree { get; set; }

        public Celsius(int degree)
        { Degree = degree; }

        public static implicit operator Kelvin(Celsius degree) { return new Kelvin(degree.Degree + 273); }
    }
}
