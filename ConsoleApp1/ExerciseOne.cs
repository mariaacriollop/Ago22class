using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Exercises
    {
        // ejercicio uno
        public static void ExecuteExercise()
        {
            int a = 0;
            int b = 0;
            int c = 0;
            Console.WriteLine("Ingrese tres números enteros.");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            int Resultado = (a + b + c) / 3;
            Console.WriteLine("El promedio de los números ingresados es: " + Resultado);

        }


        //Ejercicio Dos


        public static void ExecuteExercise2()
        {
            int alt = 0;
            int bas = 0;


            Console.WriteLine("Ingrese la altura del rectangulo.");
            alt = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la base del rectangulo.");
            bas = int.Parse(Console.ReadLine());

            int area = alt * bas;
            Console.WriteLine("El area del rectangulo es: " + area);

            int perimetro = (2 * alt + 2 * bas);
            Console.WriteLine("El perimetro del rectangulo es: " + perimetro);

        }
    
        //Ejercicio Tres
   
    
        public static void ExecuteExercise3()
        {
            double celsius = 0;



            Console.WriteLine("Ingrese la temperatura en Celsius.");
            celsius = double.Parse(Console.ReadLine());


            double fahrenheit = (celsius * 1.8) + 32;
            Console.WriteLine("La temperatira en Fahrenheit es: " + fahrenheit);
        }
    }

}
