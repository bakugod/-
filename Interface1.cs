namespace _Number
{
    using System;

    abstract class Number
    {
        public abstract int Constructor();
    }

    class Numeric : Number
    {
        static int Decimal; 

        public static int Getter(int n) => Decimal = n;

        public override int Constructor() => Decimal;

        
        static void Main()
        {

            var sss = new Getter(12);

            Console.WriteLine($"Area of the square = {sss.Constructor()}");
        }
    }

}

