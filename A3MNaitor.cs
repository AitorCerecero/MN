using System.ComponentModel;
using System.Runtime.ExceptionServices;

int control = 1;

do
{
    int op;
    Console.WriteLine("Actividad 3");
    Console.WriteLine("Programa 1");
    Console.WriteLine("Programa 2");
    op=int.Parse(Console.ReadLine());
    Console.WriteLine("Opcion Elegida: "+op);

    switch (op)
    {
        case 1:
            {
                
                Console.WriteLine("Numero de renglones");
                int NR = int.Parse(Console.ReadLine());
                Console.WriteLine("Numero de Espacios");
                int NE = int.Parse(Console.ReadLine());
                Console.WriteLine("Numero multiplicador");
                int mxp = int.Parse(Console.ReadLine());

                int[,] max = new int[NR, NE];

                for(int fil = 0; fil < max.GetLength(0); fil++)
                {
                    for (int col = 0; col < max.GetLength(1); col++){
                        Console.WriteLine("Valor a asignar al espacio: "+fil+", "+col);
                        max[fil,col]=int.Parse(Console.ReadLine());   
                     }
                }
                for (int fil = 0; fil < max.GetLength(0); fil++)
                {
                    for (int col = 0; col < max.GetLength(1); col++)
                    {
                        int mul= max[fil, col]*mxp;
                        Console.WriteLine("Valor en el espacio: "+max[fil,col]+" multiplicado por el valor: "+mxp+" Da como resultado: "+mul);
                    }
                }
                break;
            }
        case 2:
            {
                Console.WriteLine("Numero de materias del semestre");
                int mat = int.Parse(Console.ReadLine());
                int min = 100;
                int max = 0;
                int[] stats = new int[mat]; // calificaciones
                int sum = 0;
                int prom;
                for (int materia = 0; materia < stats.GetLength(0); materia++)
                {
                    Console.WriteLine("Materia: "+(materia+1));
                    stats[materia]=int.Parse(Console.ReadLine());
                    Console.WriteLine("Calificacion: " + stats[materia]);
                    sum += stats[materia];
                }
                prom= sum/stats.Length;
                Console.WriteLine("El promedio total es de: "+prom);
                int[] min_max = new int[mat];
                for(int i = 0; i < mat; i++)
                {
                    if (stats[i] > max)
                        max = stats[i];

                    if (stats[i]<min)
                        min = stats[i];

                }
                Console.WriteLine("La calificacion mas alta fue: "+max);
                Console.WriteLine("La calificacion mas baja fue: "+min);
                break;
            }
    }

    Console.WriteLine("Repetir secuencia, 1 para si y cualquier otro numero para no");
    control=int.Parse(Console.ReadLine());  

} while (control == 1);
