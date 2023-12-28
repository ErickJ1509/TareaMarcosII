using System;


namespace EjemploGitHubAlumnoMejorPromedio
{
    class Program
    {
        static void Main(string[] args)
        {
            int alumnosCount = 0;
            Console.WriteLine("Ingresa la cantidad de alumnos a registrar:");
            alumnosCount = Convert.ToInt32(Console.ReadLine());
            decimal[,] arregloCalificaciones = new decimal[alumnosCount, 2];
            Console.WriteLine();

            for (int i = 0; i < alumnosCount; i++)
            {
                Console.WriteLine("Calificación del alumno #" + (i + 1).ToString());

                decimal calificacion;
                do
                {
                    Console.Write("Ingresa la calificación (de 0 a 10): ");
                    if (decimal.TryParse(Console.ReadLine(), out calificacion) && calificacion >= 0 && calificacion <= 10)
                    {
                        break; // Sale del bucle si la calificación es válida
                    }
                    else
                    {
                        Console.WriteLine("Por favor, ingresa una calificación válida.");
                    }
                } while (true);

                arregloCalificaciones[i, 0] = calificacion; // Calificación
                arregloCalificaciones[i, 1] = (i + 1);      // Alumno
                Console.WriteLine();
            }

            // Obtener alumno con mejor promedio
            decimal mejorCalificacion = 0;
            decimal mejorAlumno = 0;
            for (int i = 0; i < alumnosCount; i++)
            {
                if (arregloCalificaciones[i, 0] > mejorCalificacion)
                {
                    mejorCalificacion = arregloCalificaciones[i, 0];
                    mejorAlumno = arregloCalificaciones[i, 1] = (i + 1);
                }
            }

            Console.WriteLine("El alumno con el mejor promedio es el alumno #{0} con una calificación de: {1}",
                mejorAlumno.ToString(),
                mejorCalificacion.ToString());
            Console.WriteLine();


            Console.ReadKey();
        }
    }
}
