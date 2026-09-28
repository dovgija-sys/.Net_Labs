using System;

namespace program_lab2.Classes
{
    public class Calculation_Task2
    {
        private int _a, _b;

        public int A { get { return _a; } set { _a = value; } }
        public int B { get { return _b; } set { _b = value; } }

        public Calculation_Task2() { _a = 1; _b = 100; }

        public Calculation_Task2(int _a, int _b)
        {
            this._a = _a;
            this._b = _b;
        }

        public Calculation_Task2(int start)
        {
            this._a = start;
            this._b = start + 50; 
        }
        public int CalculateSum()
        {
            if (_a > _b)
            {
                throw new ArgumentOutOfRangeException("a", "Межа 'a' повинна бути меншою або дорівнювати 'b'");
            }
            int sum = 0;
            for (int i = _a; i <= _b; i++)
            {
                if (i % 19 == 0 && Math.Abs(i % 3) == 2)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}