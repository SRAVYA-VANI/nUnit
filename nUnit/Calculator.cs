using System;

namespace UnitTestDemo

{
    public class Calculator
    {
        public int Addition(int x, int y)
        {
            return x + y;
        }
        public int subtraction(int x, int y)
        {
            if (x < y)
            {
                throw new ArgumentException($"{x} is less than{ y}");
            }
            return x - y;
        }
        public void Dispose()
        {
            throw new Exception("releasing memory");
        }
       
    }
}
