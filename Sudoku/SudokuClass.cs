using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication6
{
    class SudokuClass
    {
        public int[,] numbers = new int[9, 9];

        private int N;

        public SudokuClass(int n)
        {
            N = (int)System.Math.Sqrt(n);
            Generate(n);
            Update(n);
        }

        private void Generate(int n)
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    numbers[i, j] = (i * N + i / N + j) % n + 1;
        }

        private void ChangeCells(int v1, int v2, int n)
        {
            int x1 = 0, y1 = 0, x2 = 0, y2 = 0;
            for (int i = 0; i < n; i += N)
                for (int j = 0; j < n; j += N)
                {
                    for (int k = 0; k < N; k++)
                        for (int l = 0; l < N; l++)
                        {
                            if (numbers[i + k, j + l] == v1)
                            {
                                x1 = i + k;
                                y1 = j + l;
                            }
                            if (numbers[i + k, j + l] == v2)
                            {
                                x2 = i + k;
                                y2 = j + l;
                            }
                        }
                    numbers[x1, y1] = v2;
                    numbers[x2, y2] = v1;
                }

        }

        private void Update(int n)
        {
            for (int i = 0; i < n+1; i++)
            {
                var rnd1 = new Random(Guid.NewGuid().GetHashCode());
                var rnd2 = new Random(Guid.NewGuid().GetHashCode());
                ChangeCells(rnd1.Next(1, n + 1), rnd2.Next(1, n + 1), n);
            }
        }
    }
}
