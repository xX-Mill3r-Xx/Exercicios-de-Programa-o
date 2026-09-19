using po004;
using System;

namespace poo004
{
    public static class CalculoTriangulo
    {
        private static double HeronX(TrianguloX X)
        {
            double pX = ((X.A + X.B + X.C) / 2.0);
            return pX;
        }

        private static double HeronY(TrianguloY Y)
        {
            double pY = ((Y.A + Y.B + Y.C) / 2.0);
            return pY;
        }

        public static double RetornaAreaX(TrianguloX X)
        {
            double areaX = Math.Sqrt((HeronX(X) * (HeronX(X) - X.A) * (HeronX(X) - X.B) * (HeronX(X) - X.C)));
            return areaX;
        }

        public static double RetornaAreaY(TrianguloY Y)
        {
            double areaY = Math.Sqrt((HeronY(Y) * (HeronY(Y) - Y.A) * (HeronY(Y) - Y.B) * (HeronY(Y) - Y.C)));
            return areaY;
        }
    }
}
