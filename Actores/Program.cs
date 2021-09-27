using System;

namespace Ecuacion_por_los_puntos
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] PuntoO = new double[3];
            PuntoO[0] = 0;
            PuntoO[1] = 0;
            PuntoO[2] = 0;

            double[] PuntoP = new double[3];
            PuntoP[0] = 1;
            PuntoP[1] = 2;
            PuntoP[2] = 3;

            double[] PuntoQ = new double[3];
            PuntoQ[0] = -2;
            PuntoQ[1] = 3;
            PuntoQ[2] = 3;

            double[] vectorU = new double[3];
            vectorU[0] = PuntoO[0] - PuntoP[0];
            vectorU[1] = PuntoO[1] - PuntoP[1];
            vectorU[2] = PuntoO[2] - PuntoP[2];

            Console.WriteLine("{0}i", vectorU[0]);
            Console.WriteLine("{0}j", vectorU[1]);
            Console.WriteLine("{0}k", vectorU[2]);
            Console.WriteLine("");

            double[] vectorV = new double[3];
            vectorV[0] = PuntoQ[0] - PuntoP[0];
            vectorV[1] = PuntoQ[1] - PuntoP[1];
            vectorV[2] = PuntoQ[2] - PuntoP[2];

            Console.WriteLine("{0}i", vectorV[0]);
            Console.WriteLine("{0}j", vectorV[1]);
            Console.WriteLine("{0}k", vectorV[2]);
            Console.WriteLine("");

            double[] vectorN = new double[3];
            vectorN[0] = (vectorU[1] * vectorV[2]) + (-(vectorU[2] * vectorV[1]));
            vectorN[1] = (vectorU[0] * vectorV[2]) + (-(vectorU[2] * vectorV[0])) * -1;
            vectorN[2] = (vectorU[0] * vectorV[1]) + (-(vectorU[1] * vectorV[0]));

            Console.WriteLine("{0}i", vectorN[0]);
            Console.WriteLine("{0}j", vectorN[1]);
            Console.WriteLine("{0}k", vectorN[2]);

            double producto = (-PuntoP[0] * vectorN[0]) + (-PuntoP[1] * vectorN[1]) + (-PuntoP[2] * vectorN[2]);
            Console.WriteLine("\n Ecuacion que pasa por el punto: {0}x {1}y {2}z = {3}", vectorN[0], vectorN[1], vectorN[2], producto);
        }
    }
}
