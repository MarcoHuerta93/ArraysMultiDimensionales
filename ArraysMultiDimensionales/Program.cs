using System;

namespace ArraysMultiDimensionales
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //declaración de array de dos dimensiones
            string[,] matriz2D;

            //declaración de array de tres dimensiones
            int[,,] matriz3D;

            string[,] array2D = new string[,]
            {
                {"A","B","C" },
                {"D","E","F" },
                {"G","H","I" }
            };
            Console.WriteLine("El valor central es {0}", array2D[1,1]);
            Console.Read();
        }
    }
}
