using System;

namespace program_lab2.Classes
{
    public class Calculation_Task3
    {
        private double _a, _b;

        public double A { get { return _a; } set { _a = value; } }
        public double B { get { return _b; } set { _b = value; } }

        public Calculation_Task3() { _a = 3; _b = 4; }

        public Calculation_Task3(double _a, double _b)
        {
            this._a = _a;
            this._b = _b;
        }

        public Calculation_Task3(double leg)
        {
            this._a = leg;
            this._b = leg;
        }

        public double GetHypotenuse()
        {
            return Math.Sqrt(_a * _a + _b * _b);
        }

        public double GetAngleA()
        {
            return Math.Atan(_a / _b) * 180 / Math.PI;
        }

        public double GetAngleB()
        {
            return Math.Atan(_b / _a) * 180 / Math.PI;
        }

        public double GetInscribedRadius()
        {
            return (_a + _b - GetHypotenuse()) / 2;
        }
    }
}