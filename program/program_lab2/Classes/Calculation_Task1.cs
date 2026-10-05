using System;

namespace program_lab2.Classes
{
    public class Calculation_Task1
    {
        private int _a, _b, _c;

        public int A { get { return _a; } set { _a = value; } }
        public int B { get { return _b; } set { _b = value; } }
        public int C { get { return _c; } set { _c = value; } }

        public Calculation_Task1() { _a = 0; _b = 0; _c = 0; }

        public Calculation_Task1(int _a, int _b, int _c)
        {
            this._a = _a;
            this._b = _b;
            this._c = _c;
        }

        public Calculation_Task1(int value)
        {
            _a = value;
            _b = value;
            _c = value;
        }
        public double Calculate()
        {
            if (_a % 2 == 0 && _b % 2 == 0 && _c % 2 == 0)
                return _a * _b * _c;
            else if(_a < 0 || _b < 0 || _c < 0)
            {
                return Math.Pow(_a + _b + _c, 3);
            }
            else
                return Math.Pow(_a + _b + _c, 2);
        }
    }
}