using System;
using System.IO;

namespace Task2_12
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = 0;
            double B = 1;
            int N = 5;
            CreateTable(A, B, N, "D:\\2.txt");
        }

        public static void TextToFile(string text, string file)
        {
            try
            {
                StreamWriter sw = new StreamWriter(file);
                sw.WriteLine(text);
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        public static void CreateTable(double A, double B, int N, string file)
        {
            string text1 = "          x          sin(x)          cos(x)          exp(x)\r\n";
            double step = (B - A) / N;
            for (double i = A; i <= B; i += step)
            {
                text1 += i + "          " + Math.Sin(i) + "          " + Math.Cos(i) + "          " + Math.Exp(i) + "\r\n";
            }
            TextToFile(text1, file);
        }
    }
}