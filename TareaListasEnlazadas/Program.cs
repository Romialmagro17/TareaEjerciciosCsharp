using System;

public class Nodo {
    public int Dato;
    public Nodo Siguiente;
    public Nodo(int dato) {
        Dato = dato;
        Siguiente = null;
    }
}

public class ListaEnlazada {
    public Nodo Cabeza;

    public void Insertar(int dato) {
        Nodo nuevo = new Nodo(dato);
        nuevo.Siguiente = Cabeza;
        Cabeza = nuevo;
    }

    // EJERCICIO 1: Contar elementos
    public int ContarElementos() {
        int contador = 0;
        Nodo actual = Cabeza;
        while (actual != null) {
            contador++;
            actual = actual.Siguiente;
        }
        return contador;
    }

    // EJERCICIO 3: Buscar y contar coincidencias
    public int BuscarYContar(int valorABuscar) {
        int vecesEncontrado = 0;
        Nodo actual = Cabeza;
        while (actual != null) {
            if (actual.Dato == valorABuscar) {
                vecesEncontrado++;
            }
            actual = actual.Siguiente;
        }

        if (vecesEncontrado == 0) {
            Console.WriteLine("El dato " + valorABuscar + " no fue encontrado.");
        } else {
            Console.WriteLine("El dato " + valorABuscar + " se encontro " + vecesEncontrado + " veces.");
        }
        return vecesEncontrado;
    }
}

class Program {
    static void Main(string[] args) {
        ListaEnlazada miLista = new ListaEnlazada();
        
        // Datos de prueba
        miLista.Insertar(10);
        miLista.Insertar(20);
        miLista.Insertar(10);
        miLista.Insertar(30);

        Console.WriteLine("=== REVISIÓN DE TAREA ===");
        // Prueba Ejercicio 1
        Console.WriteLine("Total elementos en la lista: " + miLista.ContarElementos());
        
        // Prueba Ejercicio 3
        Console.WriteLine("\nBuscando el numero 10:");
        miLista.BuscarYContar(10);
        
        Console.WriteLine("\nBuscando el numero 99:");
        miLista.BuscarYContar(99);
    }
}