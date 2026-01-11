using System;
using System.Collections.Generic;
using System.Linq;

namespace TareaListas
{
    // Definimos una clase para organizar los ejercicios
    public class SolucionadorEjercicios
    {
        private List<string> _asignaturas = new List<string> { "Matemáticas", "Física", "Química", "Historia", "Lengua" };

        // Ejercicio 1: Almacenar y mostrar lista
        public void Ejercicio1()
        {
            Console.WriteLine("--- Ejercicio 1 ---");
            Console.WriteLine("Asignaturas: " + string.Join(", ", _asignaturas));
        }

        // Ejercicio 2: Mostrar "Yo estudio <asignatura>"
        public void Ejercicio2()
        {
            Console.WriteLine("\n--- Ejercicio 2 ---");
            foreach (var asignatura in _asignaturas)
            {
                Console.WriteLine($"Yo estudio {asignatura}");
            }
        }

        // Ejercicio 3: Preguntar notas y mostrar mensaje
        public void Ejercicio3()
        {
            Console.WriteLine("\n--- Ejercicio 3 ---");
            Dictionary<string, string> notas = new Dictionary<string, string>();

            foreach (var asignatura in _asignaturas)
            {
                Console.Write($"¿Qué nota has sacado en {asignatura}?: ");
                string nota = Console.ReadLine();
                notas.Add(asignatura, nota);
            }

            foreach (var registro in notas)
            {
                Console.WriteLine($"En {registro.Key} has sacado {registro.Value}");
            }
        }

        // Ejercicio 4: Lotería ordenada
        public void Ejercicio4()
        {
            Console.WriteLine("\n--- Ejercicio 4 ---");
            List<int> loteria = new List<int>();
            for (int i = 0; i < 6; i++)
            {
                Console.Write($"Introduce el número ganador {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int num))
                {
                    loteria.Add(num);
                }
            }
            loteria.Sort();
            Console.WriteLine("Números ordenados: " + string.Join(", ", loteria));
        }

        // Ejercicio 5: Números del 1 al 10 en orden inverso
        public void Ejercicio5()
        {
            Console.WriteLine("\n--- Ejercicio 5 ---");
            List<int> numeros = Enumerable.Range(1, 10).ToList();
            numeros.Reverse();
            Console.WriteLine(string.Join(", ", numeros));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instanciamos la clase (esto es POO)
            SolucionadorEjercicios tarea = new SolucionadorEjercicios();

            // Ejecutamos los métodos
            tarea.Ejercicio1();
            tarea.Ejercicio2();
            tarea.Ejercicio3();
            tarea.Ejercicio4();
            tarea.Ejercicio5();

            Console.WriteLine("\nTarea finalizada. Presiona cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}