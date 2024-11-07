using LabUnitTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1()
        {
            Class1 class1 = new Class1();
            int[] input = new int[15] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            int[,] expected = new int[5, 5]
            {
                { 1, 0, 0, 0, 0 },
                { 2, 3, 0, 0, 0 },
                { 4, 5, 6, 0, 0 },
                { 7, 8, 9, 10, 0 },
                { 11, 12, 13, 14, 15 }
            };

            // Act
            int[,] result = class1.BuildLowerTriangularMatrix(input);

            // Assert
            CollectionAssert.AreEqual(expected, result);
        }


    }
}