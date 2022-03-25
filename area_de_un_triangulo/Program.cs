using System;

namespace area_de_un_triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarado de variables
            int b = 25;
            int a = 60;
            int area;

            //Colocar el rocedimiento
            area = (b * a) / 2;

            //Imprimir en pantalla el resultado
            Console.WriteLine("El área del triángulo es de: " + area);
            Console.ReadKey(true);

        }
    }
}
