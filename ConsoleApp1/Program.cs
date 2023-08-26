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