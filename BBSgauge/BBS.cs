using System;
using System.Collections.Generic;

namespace BBSgauge
{
    public class BBS
    {
        public int N;
        public List<long> U;
        private int maxValue = 5000;
        private Random rnd = new Random();

        public BBS()
        {
            U = new List<long>();
            N = CreateN();
        }

        public BBS(int numb)
        {
            U = new List<long>();
            N = numb;
            maxValue = numb;
        }

        private int CreateN()
        {
            int p = rnd.Next(0, maxValue);
            while (p % 4 != 3 || !isSimple(p))
            {
                p++;
            }
            int q = p + 1;
            while (q % 4 != 3 || !isSimple(q))
            {
                q++;
            }
            return p * q;
        }

        private bool isSimple(int numb)
        {
            for (int i = 2; i <= numb / 2; i++)
            {
                if (numb % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private long NOD(long a, long b)
        {
            if (a == b)
            {
                return a;
            }
            else
            {
                if (a > b)
                {
                    return NOD(a - b, b);
                }
                else
                {
                    return NOD(b - a, a);
                }
            }
        }

        public void GenerateSequense()
        {
            long x = rnd.Next(0, maxValue);
            while (NOD((int)x, N) != 1)
            {
                x++;
            }
            long startNumber = (x * x) % N;
            U.Add(startNumber);
            long nextNumber = (startNumber * startNumber) % N;
            while (!U.Contains(nextNumber))
            {
                U.Add(nextNumber);
                nextNumber = (nextNumber * nextNumber) % N;
            }
        }
    }
}
