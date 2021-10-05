using System;
using System.Collections.Generic;
using System.Text;

namespace Polynom
{
    class Polynomial
    {
        int[] koef; //массив коэф-ов
        int step; //значение степени полинома

        public Polynomial(int[] k, int s)
        {
            koef = k;
            step = s;
        }

        //сложение полиномов
        public static Polynomial max_pol(Polynomial A, Polynomial B)
        {
            if (A.step > B.step)
            {
                return A;
            }
            else
                return B;
        }
        public static Polynomial operator +(Polynomial A, Polynomial B)
        {
            int D1 = max_pol(A, B).step;
            int[] M1 = new int[D1 + 1];
            Polynomial C = new Polynomial(M1, D1);
            if (A.step > B.step)
            {
                for (int i = 0; i < B.koef.Length; i++)
                {
                    C.koef[i] = A.koef[i] + B.koef[i];
                }
                for (int j = B.koef.Length; j < M1.Length; j++)
                {
                    C.koef[j] = max_pol(A, B).koef[j];
                }
            }
            else
            {
                for (int i = 0; i < A.koef.Length; i++)
                {
                    C.koef[i] = A.koef[i] + B.koef[i];
                }
                for (int j = A.koef.Length; j < M1.Length; j++)
                {
                    C.koef[j] = max_pol(A, B).koef[j];
                }
            }

            return C;
        }

        //вычитание полиномов
        public static Polynomial operator -(Polynomial A, Polynomial B)
        {
            int D1 = max_pol(A, B).step;
            int[] M1 = new int[D1 + 1];
            Polynomial C = new Polynomial(M1, D1);
            if (A.step > B.step)
            {
                for (int i = 0; i < B.koef.Length; i++)
                {
                    C.koef[i] = A.koef[i] - B.koef[i];
                }
                for (int j = B.koef.Length; j < M1.Length; j++)
                {
                    C.koef[j] = max_pol(A, B).koef[j];
                }
            }
            else
            {
                for (int i = 0; i < A.koef.Length; i++)
                {
                    C.koef[i] = A.koef[i] - B.koef[i];
                }
                for (int j = A.koef.Length; j < M1.Length; j++)
                {
                    C.koef[j] = max_pol(A, B).koef[j];
                }
            }
            return C;
        }

        //умножение полиномов
        public static Polynomial operator *(Polynomial A, Polynomial B)
        {
            int D1 = A.step + B.step;
            int[] M1 = new int[D1 + 1];
            Polynomial C = new Polynomial(M1, D1);
            for (int i = 0; i <= A.step; i++)
            {
                for (int j = 0; j <= B.step; j++)
                {
                    C.koef[i + j] += A.koef[i] * B.koef[j];
                }
            }
            return C;
            
        }

        //вывод полинома
        public void show()
        {
            for (int i = step+1,j=0; i !=0; j++,i--)
            {
                Console.Write("+" + koef[j] + "x^" + (j));
            }
            //return 0;
        }

        public void  Parse(string S)
        {
            string[] SS = S.Split("+X");
            this.koef = new int[SS.Length];
            this.step = SS.Length - 1;
            for (int i = 0; i < koef.Length; i++)
                this.koef[i] = int.Parse(SS[i]);
        }

    }
}
