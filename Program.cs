using System.Globalization;
using System.Security.Cryptography.X509Certificates;

int control = 1;
int op;


do
{
    Console.WriteLine("Actividad 11");
    Console.WriteLine("Parte 1");
    Console.WriteLine("Parte 2");
    Console.WriteLine("Parte 3");
    op = int.Parse(Console.ReadLine());
    switch (op)
    {
        case 1:
            {
                double[] x = { -5, -3, -0.7, 0.25, 2.1, 6, 7.46, 19.1, 15.5 };
                double[] y = { 6, 5.3, 1.53, -2.7, 4, 9.1, 2.2, 3.5, 6.2 };
                double xA = 6.574, yA = 0;
                //Variables del programa
                int datos = x.Length; //Cantidad de elementos en X
                double[,] matriz = new double[datos, datos + 1];
                //RECORRER MATRIZ (CUADRADA)
                for (int i = 0; i < datos; i++) //RENGLONES
                {
                    for (int j = 0; j < datos; j++) //COLUMNAS
                    { //EL PRIMER VALOR DE X SE ELEVA A LA 0 , 1, 2 ,3, 4, 5
                        matriz[i, j] = Math.Pow(x[i], j);
                    }
                }

                //VACIAR EL VECTOR Y EN LA ULTIMA COLUMNA DE LA MATRIZ.
                for (int i = 0; i < datos; i++)
                {
                    matriz[i, datos] = y[i];
                }

                for (int i = 0; i < datos; i++) //RENGLONES
                {
                    for (int j = 0; j < datos + 1; j++) //COLUMNAS
                    { //EL PRIMER VALOR DE X SE ELEVA A LA 0 , 1, 2 ,3, 4, 5
                        Console.Write(matriz[i, j] + "\t");
                    }
                    Console.WriteLine();
                }

                //APLICAR GAUSS
                Console.WriteLine("INICIA GAUSS: ");
                int ren = datos, col = ren + 1;
                //VARIABLES FIJAS
                double factor, pivote;

                // Recorrer matriz para imprimir datos
                for (int r = 0; r < ren; r++) //RECORRER RENGLONES r = 0 -> 1 -> 2
                {
                    pivote = matriz[r, r];
                    for (int c = 0; c < col; c++) //RECORRER COLUMNAS C = 0 
                    {
                        //   if(matriz[r,c]==0)
                        matriz[r, c] = matriz[r, c] / pivote;
                        //  matriz[r,c] /= pivote;   
                    }
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

                //imprimir en formar en ecuación
                for (int r = 0; r < ren; r++)
                {
                    if (r < ren - 1)
                    {
                        Console.Write(matriz[r, col - 1] + "x^" + r + " + ");
                    }
                    else
                    {
                        Console.Write(matriz[r, col - 1] + "x^" + r);
                    }
                }

                //EVALUAR LA FUNCION EN xA = 1.5
                for (int r = 0; r < ren; r++)
                {
                    yA += matriz[r, datos] * Math.Pow(xA, r);
                }
                Console.WriteLine("El valor de y evaluado en " + xA + " es: " + yA);

            }
            break;

        case 2:
            {
                double[] x = { -5, -3, -0.7, 0.25, 2.1, 6, 7.46, 19.1, 15.5 };
                double[] y = { 6, 5.3, 1.53, -2.7, 4, 9.1, 2.2, 3.5, 6.2 };
                double xA = 6.574, yA = 0;

                int datos = x.Length; //Cantidad de elementos en X
                double[] lagrange = new double[datos];

                for (int i = 0; i < datos; i++) //FOR FIJO
                {
                    lagrange[i] = 1;
                    for (int j = 0; j < datos; j++) //FOR MOVIL
                    {
                        if (i != j)
                        {
                            lagrange[i] *= (xA - x[j]) / (x[i] - x[j]);
                        }
                    }
                    ///MULTIPLICAR CASILLA DE LAGRANGE * LA CASILLA Y
                    lagrange[i] *= y[i];
                    //ACUMULAR CADA CASILLA DE LAGRANGE EN YA
                    yA += lagrange[i];
                }

                //IMPRIMIR
                for (int j = 0; j < datos; j++)
                {
                    Console.WriteLine(lagrange[j]);
                }

                //IMPRIMIR RESULTADO FINAL
                Console.WriteLine("El valor de y evaluado en " + xA + " es: " + yA);
            }
            break;
        case 3:
            {
                double[] x = { -5, -3, -0.7, 0.25, 2.1, 6, 7.46, 19.1, 15.5 };
                double[] y = { 6, 5.3, 1.53, -2.7, 4, 9.1, 2.2, 3.5, 6.2 };
                double yA;
                double x1 = -5;
                double x2 = 32;
                double dec = 0.4;
                while(x1<=x2)
                {
                    double xA = x1 += dec;
                    int datos = x.Length; //Cantidad de elementos en X
                    double[] lagrange = new double[datos];
                    yA = 0;

                    for (int j = 0; j < datos; j++) //FOR FIJO
                    {
                        lagrange[j] = 1;
                        for (int k = 0; k < datos; k++) //FOR MOVIL
                        {
                            if (j != k)
                            {
                                lagrange[j] = (xA - x[k]) / (x[j] - x[k]);
                            }
                        }
                        //MULTIPLICAR CASILLA DE LAGRANGE LA CASILLA Y
                        lagrange[j] *= y[j];
                        //ACUMULAR CADA CASILLA DE LAGRANGE EN YA
                        yA += lagrange[j];
                    }

                    //IMPRIMIR RESULTADO FINAL
                    Console.WriteLine("El valor de y evaluado en " + xA + " es: " + yA);
                }
            }
            break;
    }
    Console.WriteLine("Para Repetir presiona cualquier 1 y para salir presiona cualquier otro numero");
    op=int.Parse(Console.ReadLine());

} while (op == 1);