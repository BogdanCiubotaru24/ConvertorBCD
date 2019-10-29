using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertor_in_BCD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numarul de convertit in BCD:");
            int numarInitial;
            numarInitial = Convert.ToInt32(Console.ReadLine());
            if (numarInitial < 0)
                numarInitial = Complement(numarInitial);
            ConversieBinara(numarInitial);
        }
        
        public static int Complement(int n)
        {
            int scazut = 0;
            int lungime = Convert.ToString(n).Length;
            while(lungime != 0)
            {
                scazut = scazut * 10 + 9;
                lungime--;
            }
            return scazut + n + 1;
        }

        public static void ConversieBinara(int n)
        {
            int cifra;
            int[] inBaza2 = new int[4];
            int index;
            int lungime = (int)Math.Pow(10 , Convert.ToString(n).Length - 1);
            StringBuilder Concatenare = new StringBuilder();
            while (lungime != 0)
            {
                index = 3;
                for (int i = 0; i <= 3; i++)
                    inBaza2[i] = 0;
                cifra = n / lungime % 10;
                while(cifra != 0)
                {
                    inBaza2[index] = cifra % 2;
                    cifra /= 2;
                    index--;
                }
                lungime = lungime / 10;
                
                for (int i = 0; i <= 3; i++)
                {
                    Concatenare.Append(inBaza2[i]);
                }
                Concatenare.Append(" ");

            }
            string rezultatFinal = Convert.ToString(Concatenare);
            Console.WriteLine(rezultatFinal);
        }
    }
}
