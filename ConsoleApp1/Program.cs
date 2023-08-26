using System.Linq.Expressions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Menú para seleccionar que programa ejecutar 
            //switch Case para la ejecucion de los ejercicios

            Console.WriteLine("Ingrese el número del ejercicio que desea probar.");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("1. para ingresar 3 números y obtener el promedio.");
            Console.WriteLine("2. para ingresar la altura y base de un rectangúlo y obtener el perimetro y area de este.");
            Console.WriteLine("3. Para ingresar temperatura en Celsius y obtenerla en grados Fahrenheit.");
            int ejercicio = 0;
            ejercicio = int.Parse(Console.ReadLine());

            switch (ejercicio)
            {
                case 1:
                    Console.WriteLine("Ejercicio 1");
                    Exercises.ExecuteExercise();
                    break; 
                case 2:
                    Console.WriteLine("Ejercicio 2");
                    Exercises.ExecuteExercise2();
                    break; 
                case 3:
                    Console.WriteLine("Ejercicio 3");
                    Exercises.ExecuteExercise3();
                    break;




            }

            
            
        }
    }
}