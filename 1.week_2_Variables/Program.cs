using System;

namespace _1.week_2_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 25;

            double price = 99.99;

            string name = "Enes Kılıç";

            bool isStudent = true;

            char grade = '4';

            DateTime currentDate = DateTime.Now;

            Tuple<string, byte> person = new Tuple<string, byte>("enes kılıç", 26);

            // 75,65,78,80

            int[] score = new int[5];

            int[] scores2 = new int[] { 75 };

            DateTime? birtDate = DateTime.Now;
        }
    }
}
