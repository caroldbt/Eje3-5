using System;

namespace Eje3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("+---------Ejercicio 3---------+");
            int x = 8;
            int y = 7;
            double n = 5;
            double m = 9;
            System.Console.WriteLine("x = {0}, y = {1}, n = {2}, m = {3}", x, y, n, m);
            System.Console.WriteLine("x + y  = " + (x + y));
            System.Console.WriteLine("x - y = " + (x - y));
            System.Console.WriteLine("x * y = " + (x * y));
            System.Console.WriteLine("x / y = " + (x / y));
            System.Console.WriteLine("x % y = " + (x % y));
            System.Console.WriteLine("n + m  = " + (n + m));
            System.Console.WriteLine("n - m = " + (n - m));
            System.Console.WriteLine("n * m = " + (n * m));
            System.Console.WriteLine("n / m = " + (n / m));
            System.Console.WriteLine("n % m = " + (n % m));
            System.Console.WriteLine("x + n = " + (x + n));
            System.Console.WriteLine("y / m = " + (y / m));
            System.Console.WriteLine("y % m = " + (y % m));
            System.Console.WriteLine("El doble de cada variable es: x=" + Math.Pow(x, 2) + ", y=" + Math.Pow(y, 2)
                + ", n=" + Math.Pow(n, 2) + ", m=" + Math.Pow(m, 2));
            System.Console.WriteLine("La suma de todas las variables: x + y + n + m = " + (x + y + n + m));
            System.Console.WriteLine("El producto de todas las variables: x * y * n * m = " + (x * y * n * m));

        }
    }
}
