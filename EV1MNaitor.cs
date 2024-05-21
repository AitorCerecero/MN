using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EV1MNaitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int filas; //Para generar las filas
            int columnas; //Para generar las columnas
            int elementos; //Para contar los elementos, en una matriz los elementos se generan multiplicando Filas por Columnas dando paso al numero de elementos
            Console.WriteLine("Evidencia 1");
            do
            {
                Console.WriteLine("Numero de Filas: ");
                filas = int.Parse(Console.ReadLine()); //Pide las filas
                Console.WriteLine("Numero de Columnas: "); 
                columnas = int.Parse(Console.ReadLine()); // Pide las columnas 
                elementos = filas * columnas; //operacion que cuenta el total de elementos

                if (elementos > 16){ // Si los elementos mediante la operacion son mayor a 16 pide de nuevo los datos
                    Console.WriteLine("Que todos tus elementos sean menor a 16 por favor: ");
                }
            } while (elementos > 16);
            int[,] max = new int[filas, columnas];
            for (int i = 0; i < filas; i++)
            { //Recorrer las filas
                for (int j = 0; j < columnas; j++)
                {//Recorrer las columnas
                  do { 
                  Console.Write("Valor para el espacio: ");
                  max[i, j] = int.Parse(Console.ReadLine());
//Solicita los valores para cada espacio de cada elemento de la matriz 
                  if(max[i, j] < 200 || max[i, j] > 600){
                    Console.WriteLine("Necesitas valores mas chicos o mas grandes, ponlos de nuevo"); // Si el valor es menor a 200 o mayor a 600 pedira valores de nuevo 
                  }
                   } while (max[i, j] < 200 || max[i, j] > 600);
                }
            }
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write("Valor: "+ max[i, j]);
                }
            }
//Despliegue inicial de elementos sin mover nada
            for (int fila = 0;fila< max.GetLength(0) ; fila++)
            {
                for (int col = 0; col < max.GetLength(1); col++)
                {
                    int collatz = max[fila, col];
                    while (collatz != 1)
                    {//Operacion de conjetura de collatz donde si es un numero para se divide entre dos y si no lo es se multiplica por tres y se suma 1 
                        if (collatz % 2 == 0) 
                        {
                            collatz = collatz / 2;
                        }
                        else 
                        {
                            collatz = collatz * 3 + 1;
                        }
                        Console.Write("Numero operado: "+collatz 
+ "  "); //Despliegue de pasos hasta llegar a 1 
                    }
                }
            }
        }
}
}