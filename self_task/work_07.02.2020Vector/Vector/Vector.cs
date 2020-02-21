using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    class Vector
    {
        private double x { get; set; }
        private double y { get; set; }
        private double z { get; set; }

        public Vector(double X, double Y, double Z)
        {
            x = X;
            y = Y;
            z = Z;
        }

        public double Length()
        {
            double L = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2));
            return L;
        }

        public double ScalarProduct(Vector vector1)
        {
            double S = x * vector1.x + y * vector1.y + z * vector1.z;
            return S;
        }

        public double VectorProduct(Vector vector1)
        {
            double X = (y * vector1.z - z * vector1.y);
            double Y = (z * vector1.x - x * vector1.z);
            double Z = (x * vector1.y - y * vector1.x);

            
            Vector vector2 = new Vector(X, Y, Z);
            return X;
            
        }

        public override string ToString()
        {
            return ($"vector: X: {x}, Y: {y}, Z: {z}");
        }
    }
}
