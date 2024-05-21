
using System;

public class Program
{
    public static void Main()
    {
        // VARIABLES FIJAS
        double factor, pivote;
        int contadorCero = 0;
        int ren;
        Console.WriteLine("Numero de Renglones");
        ren = int.Parse(Console.ReadLine());
        int col = ren + 1;
        bool imprimir = true;
        double[,] matriz = new double[ren, col];
        for (int i = 0; i < ren; i++)
        {
            for(int j = 0; j < col; j++)
            {
                Console.WriteLine("Valores: ");
                matriz[i, j] = int.Parse((string)Console.ReadLine());
            }
        }
        for (int i = 0; i < ren; i++)
        {
            for (int j = 0; j < col; j++)
            {
                Console.WriteLine("{"+ matriz[i, j]+"}"+"\n");
                
            }
        }
        //VALORES DEL SISTEMA DE ECUACIONES A RESOLVER
        // Recorrer matriz para imprimir datos
        for (int r = 0; r < ren; r++) //RECORRER RENGLONES r = 0 -> 1 -> 2
        {
            pivote = matriz[r, r];
            for (int c = 0; c < col; c++) //RECORRER COLUMNAS C = 0 
            {
                if (pivote == 0)
                {
                    //Console.WriteLine("PIVOTE CERO!!!");
                    if (matriz[r, c] == 0)
                    {
                        contadorCero++;
                        //Console.WriteLine("CERO DETECTADO!!!");
                    }
                }
                matriz[r, c] = matriz[r, c] / pivote;
                //  matriz[r,c] /= pivote;   
            }
            Console.WriteLine("Cantidad de ceros: " + contadorCero);
            if (contadorCero == col)
            {
                Console.WriteLine("Matriz sin Solución");
                imprimir = false;
                //System.Environment.Exit(0);
                break;
            }
            if (contadorCero != 0 && contadorCero < col)
            {
                Console.WriteLine("Matriz con una cantidad infinita de soluciones.");
                imprimir = false;
                //System.Environment.Exit(0);
                break;
            }
            contadorCero = 0;
            //VOLVER A RECORRER LA MATRIZ PARA HACER LAS CONVERSIONES A CERO
            for (int rCero = 0; rCero < ren; rCero++)
            {
                if (r != rCero) //BRINCAR EL RENGLON DEL PIVOTE
                {
                    factor = matriz[rCero, r];

                    for (int cCero = 0; cCero < col; cCero++)
                    {
                        //(VALOR ORIGINAL ) – (RENGLON DEL PIVOTE,C)(FACTOR))\
                        matriz[rCero, cCero] = matriz[rCero, cCero] - (factor * matriz[r, cCero]);
                        //matriz[rCero, cCero] -= (factor* matriz[r,cCero]);
                    }
                }
            }
        }
        //DESPLEGAR VALORES DE LAS INCOGNITAS RESULTANTE
        if (imprimir)
        {
            for (int r = 0; r < ren; r++)
            {
                Console.WriteLine("Variable " + (r + 1) + ": " + matriz[r, col - 1]);
            }

            //DESPLEGAR MATRIZ RESULTANTE
            for (int r = 0; r < ren; r++) //RECORRER RENGLONES r = 0 -> 1 -> 2
            {
                for (int c = 0; c < col; c++) //RECORRER COLUMNAS C = 0 
                {
                    Console.Write(matriz[r, c] + "\t");
                }
                Console.WriteLine();
            }
        }


    }
}
