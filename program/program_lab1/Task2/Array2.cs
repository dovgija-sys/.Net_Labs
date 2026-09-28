namespace program_lab1.Task2
{
    public class Array2
    {
        public bool error = false;
        private int _Xlength = 3;
        private int _Ylength = 3;
        public int[,] B;
        
        public Array2(int xLength, int yLength)
        {
            Xlength = xLength;  
            Ylength = yLength;
            B = new int[_Xlength, _Ylength];
            FillArray(-10, 11);
        }
        public void FillArray(int min, int max)
        {
            Random rand = new();
            for (int i = 0; i < _Xlength; i++)
            {
                for (int j = 0; j < _Ylength; j++)
                {
                    B[i, j] = rand.Next(min, max);
                }
            }
        }
        public int Count()
        {
            int count = 0;
            for (int i = 0; i < _Xlength; i++)
            {
                for (int j = i+1; j < _Ylength; j++)
                {
                    if (B[i, j] > 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        public int Xlength
        {
            get { return _Xlength; }
            set
            {
                if (value < 1)
                {
                    error = true;
                }
                else
                {
                    _Xlength = value;
                }
            }
        }
        public int Ylength
        {
            get { return _Ylength; }
            set
            {
                if (value < 1)
                {
                    error = true;
                }
                else
                {
                    _Ylength = value;
                }
            }
        }
        public int this[int indexI, int indexJ]
        {
            get
            {
                if (indexI >= 0 && indexI <= _Xlength && indexJ >= 0 && indexJ <= _Ylength)
                {
                    return B[indexI, indexJ];

                }
                else
                {
                    error = true;
                    return 0;
                }
            }
            set
            {
                if (indexI >= 0 && indexI <= _Xlength && indexJ >= 0 && indexJ <= _Ylength)
                {
                    B[indexI, indexJ] = value; ;

                }
                else
                {
                    error = true;
                }
            }

        }
    }
}
