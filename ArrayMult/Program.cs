using System;

namespace ArrayMult
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating a new 2x2 matrix and assigning the arguments
            float[,] matrixA = new float[2, 2];
            matrixA[0, 0] = float.Parse(args[0]);
            matrixA[0, 1] = float.Parse(args[1]);
            matrixA[1, 0] = float.Parse(args[2]);
            matrixA[1, 1] = float.Parse(args[3]);

            //Creating a new 2x1 matrix and assigning the arguments
            float[,] matrixB = new float[2, 1];
            matrixB[0, 0] = float.Parse(args[4]);
            matrixB[1, 0] = float.Parse(args[5]);
        }
    }
}
