using LabUnitTest;
// Исходная матрица-строка из 15 элементов
int[] matrixRow = new int[15] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

// Создаем экземпляр Class1 и строим нижнюю треугольную матрицу
Class1 class1 = new Class1();
int[,] lowerTriangularMatrix = class1.BuildLowerTriangularMatrix(matrixRow);

// Вывод нижней треугольной матрицы в Main
PrintMatrix(lowerTriangularMatrix);
    

    static void PrintMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}