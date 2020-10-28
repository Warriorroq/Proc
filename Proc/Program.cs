using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proc
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
        //Proc16
        public int Sign(int X)
            => X > 0 ? 1 :(X < 0 ? -1 : 0);
        //Proc17
        public int RootsCount(int A, int B, int C)
            => Pow(B, 2) - 4 * A * C > 0 ? 2 : (Pow(B, 2) - 4 * A * C < 0 ? 0 : 1);
        //Proc18
        public double CircleS(double R)
            => Math.PI * Pow(R,2);
        //Proc19
        public double RingS(double R1, double R2)
            => Math.PI * Pow(R1, 2) - Math.PI * Pow(R2, 2);
        //Proc20 
        public double TriangleP(double a, double h)
            => Side(a, h) * 2 + a;
        //Proc21
        public int SumRange(int start,int end)
        {
            if (start > end)
                return 0;

            int sum = 0;

            for (; start <= end; start++)
                sum += start;

            return sum;
        }
        //Proc22
        public double Calc(double a, double b, double o)
        {
            switch (o)
            {
                case 1:
                    return a - b;

                case 2:
                    return a * b;

                case 3:
                    return a / b;

                default:
                    return a + b;
            }

        }
        //Proc23
        public int Quarter(double x, double y)
            => y > 0 ? (x > 0  ? 1 : 2) : (x > 0 ? 4 : 3);
        //Proc24
        public bool Even(int k)
            => k%2==0 ? false : true;
        //Proc25
        public bool IsSquare(int k)
            => Math.Sqrt(k) ==(int)Math.Sqrt(k);
        //Proc26
        public bool IsPower5(double k)
            => k / 5 == 1  ? true : (k/5 > 1 ? IsPower5(k/5) : false);
        //help        
        public static double Side(double a, double h) 
            => Pow(a / 2, 2) + Pow(h, 2);
        public static double Pow(double num,int koren)
            =>Math.Pow(num, koren);

    }
}
