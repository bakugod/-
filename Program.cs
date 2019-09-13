namespace octoCat
{
    using System;
    class Program
    {
        
        public static long Test(int x)
        {
            var i = x * x;
            return i;
        }
        
        private static void Main2()
        {
            

            Console.WriteLine(Test(10));
        }
    }
}
