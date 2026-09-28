namespace program_lab1.Task2

{
    public class Array1
    {
        public bool error = false;
        private int length = 10;
        public WindRecord[] A;
        public Array1()
        {
            A = new WindRecord[length];
        }
        public Array1(WindRecord[] mas)
        {
            A = mas;
        }
        public Array1(int len)
        {
            length = len;
            A = new WindRecord[length];
            Random rand = new();
            for(int i = 0; i < length; i++)
            {
                string direction;
                int r = rand.Next(1, 5);
                if(r == 1){direction = "Північний";}
                else if(r == 2){direction = "Південний";}
                else if(r == 3){direction = "Західний";}
                else{direction = "Східний";}
                this[i] = new WindRecord(direction,rand.Next(0, 31));
            }
        }
        public int Count()
        {
            int count = 0;
            for (int i = 0; i < length; i++)
            {
                if (this[i].Power > 8 && this[i].Direction == "Південний")
                {
                    count++;
                }
            }
            return count;
        }
        public int Length { get { return length; } set { length = value; } }
        public WindRecord this[int index]
        {
            get
            {
                if (index < 0 || index >= length)
                {
                    error = true;
                    return null;
                }
                else
                {
                    error = false;
                    return A[index];
                }
            }
            set
            {
                if (index < 0 || index >= length)
                {
                    error = true;
                }
                else
                {
                    error = false;
                    A[index] = value;
                }
            }
        }
    }
}
