using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector vector = new Vector(4, 7, 8 );
            Vector vector1 = new Vector(3, 5, 9);

            Console.WriteLine(vector.ToString());
            Console.WriteLine(vector1.ToString());

            vector.Length();
            Console.WriteLine($"Длина вектора: {vector.Length()}");

            vector.ScalarProduct(vector1);
            Console.WriteLine($"Скалярное произведение: {vector.ScalarProduct(vector1)}");

            vector.VectorProduct(vector1);
            Console.WriteLine($"Векторное произведение: {vector.VectorProduct(vector1)}");

            Console.ReadKey();
        }
    }
}
