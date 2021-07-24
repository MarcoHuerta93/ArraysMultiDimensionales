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


            string[,,] array3D = new string[,,]
            {
                {

                {"A","B","C" },
                {"D","E","F" },
                {"G","H","I" }

                },

                {

                {"J","K","L" },
                {"M","N","O" },
                {"P","Q","R" }
                },

                {

                {"S","T","U" },
                {"V","W","X" },
                {"Y","Z", "*"}

                }
            };
            Console.WriteLine("El valor central es {0}", array2D[2,0]);
            Console.WriteLine("El valor de Q es {0}", array3D[1,2,1]);
            Console.WriteLine("El valor de V es {0}", array3D[2,1,0]);
            Console.Read();
        }
    }
}
