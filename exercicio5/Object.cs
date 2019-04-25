using System;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace exercicio5
{


    static class Object
    {
        private static double angulo = 45;
        private static double raio = 100;
        private static Matematica mat = new Matematica();
        public static Ponto4D PontoA = new Ponto4D(0, 0);
        public static Ponto4D PontoB = mat.ptoCirculo(45, 100);

        public static void ChangeAngle(string angle)
        {
            if (angle == "plus")
            {
                if (angulo >= 360)
                {
                    angulo = 0;
                } else
                {
                    angulo++;
                }
            } else if (angle == "minus")
            {
                if (angulo <= 0)
                {
                    angulo = 360;
                } else
                {
                    angulo--;
                }
            }
            PontoB = mat.ptoCirculo(angulo, raio);
        }

        public static void ChangeRay(string r)
        {
            if (r == "plus")
            {
                raio++;
            } else if (r == "minus")
            {
                raio--;
            }
            PontoB = mat.ptoCirculo(angulo, raio);
        }

        public static void WalkRight()
        {
            PontoA.X += 3;
            PontoB.X += 3;
        }

        public static void WalkLeft()
        {
            PontoA.X -= 3;
            PontoB.X -= 3;
        }

    }
}