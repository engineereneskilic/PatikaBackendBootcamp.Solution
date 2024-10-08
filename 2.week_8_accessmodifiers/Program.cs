using System;
using System.Security.Cryptography.X509Certificates;

namespace _2.week_8_accessmodifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        private int Carp(int a , int b)
        {
            return a * b;
        }

        public int Topla(int a, int b)
        {
            int toplam = a + b;
            return Carp(toplam, b);
        }
    }
}
