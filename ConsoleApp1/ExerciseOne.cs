using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ExerciseOne
    {
        public static void ExecuteExercise()
        {
            int a = 0;
            int b = 0;
            int c = 0; 
            Console.WriteLine("Ingrese tres números enteros.");
            a = int.Parse(Console.ReadLine());
            b= int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            int Resultado = (a + b + c) / 3;
            Console.WriteLine("El promedio de los números ingresados es: " + Resultado);    

        }
    }
}
