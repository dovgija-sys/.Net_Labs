namespace program_lab1
{
    public class ClassForСalculations
    {
        public double[,] xy = new double[1000, 2];
        public int n = 0;
        private double F1(double x) => Math.Pow(3*x-1, 2)/Math.Pow(x, 5);
        private double F2(double x) => Math.Pow(Math.Log(Math.Abs(Math.Sqrt(x+5))), 2);
        private double F3(double x) => Math.Sqrt(Math.Cos(1+ x*x));

        public void Tab(double xn = -2.46,
                        double xk = 28.8,
                        double h = 0.6,
                        double a = 1)
        {
            double x = xn, y;
            int i = 0;
            while (x <= xk)
            {
                if (x < 0)
                {
                    y = F1(x);
                }
                else if (x < a && x >= 0)
                {
                    y = F2(x);
                }
                else
                {
                    y = F3(x);
                }
                xy[i, 0] = x;
                xy[i, 1] = y;
                x += h;
                i++;
            }
            n = i;
        }
    }
}
