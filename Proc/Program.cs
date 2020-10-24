using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proc
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.ReadKey();
        }
        //Proc16
        static int Sign(int X)
            => X > 0 ? 1 :(X < 0 ? -1 : 0);
        //Proc17
        static int RootsCount(int A, int B, int C)
            => Pow(B, 2) - 4 * A * C > 0 ? 2 : (Pow(B, 2) - 4 * A * C < 0 ? 0 : 1);
        //Proc18
        static double CircleS(double R)
            => Math.PI * Pow(R,2);
        //Proc19
        static double RingS(double R1, double R2)
            => Math.PI * Pow(R1, 2) - Math.PI * Pow(R2, 2);
        //Proc20 
        static double TriangleP(double a, double h)
        => Side(a, h) * 2 + a;
        //Proc21

        //help 
        static double Side(double a, double h) 
            => Pow(a / 2, 2) + Pow(h, 2);
        static double Pow(double num,int koren)
            =>Math.Pow(num, koren);

    }
}
