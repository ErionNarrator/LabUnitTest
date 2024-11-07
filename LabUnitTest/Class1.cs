using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabUnitTest
{
    public class Class1
    {
        public int[,] BuildLowerTriangularMatrix(int[] row)
        {
            int size = 5; 
            int[,] lowerTriangularMatrix = new int[size, size];

            int index = 0; // Индекс для доступа к элементам исходного массива
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    lowerTriangularMatrix[i, j] = row[index++];
                }
            }

            return lowerTriangularMatrix;
        }
    }
}