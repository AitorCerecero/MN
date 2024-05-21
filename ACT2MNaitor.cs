using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace C2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int control = 1;
            do
            {
                int op;
                Console.WriteLine("Actividad 2");
                Console.WriteLine("Programa 1");
                Console.WriteLine("Programa 2");
                Console.WriteLine("Programa 3");
                op = int.Parse(Console.ReadLine());
                Console.WriteLine("Opcion elegida: " + op);

                switch (op)
                {
                    case 1:
                        int horas;
                        int horas_recomendada = 8;
                        Console.WriteLine("¿A que hora te duermes?");
                        horas = int.Parse(Console.ReadLine());
                        while (horas < 0 || horas > 23)
                        {
                            Console.WriteLine("Pon una hora realista");
                            horas = int.Parse(Console.ReadLine());
                        }
                        int horas_control = horas;
                        int hora_sugerida = horas - horas_recomendada;
                        if (horas_control == 23 || horas_control == 0 || horas_control == 1)
                        {
                            Console.WriteLine("Duermes poco, hora recomendada: " + hora_sugerida);
                        }
                        if (horas_control == 2 || horas_control == 3 || horas_control == 4)
                        {
                            Console.WriteLine("Duermes muy tarde, hora recomendada: " + hora_sugerida);
                        }
                        if (horas_control == 5 || horas_control == 6 || horas_control == 7 || horas_control == 8 || horas_control == 9 || horas_control == 10)
                        {
                            Console.WriteLine("Duermes extremadamente tarde, si tienes turno nocturno aun asi debes cuidar tu ciclo de sueño, hora sugerida:  " + hora_sugerida);
                        }
                        if (horas_control == 11 || horas_control == 12 || horas_control == 13 || horas_control == 14 || horas_control == 15 || horas_control == 16 || horas_control == 17 || horas_control == 18)
                        {
                            Console.WriteLine("Duermes extremadamente tarde, no quiero imaginar tus ojeras, hora sugerida:  " + hora_sugerida);
                        }
                        if (horas_control == 19 || horas_control == 20)
                        {
                            Console.WriteLine("Duermes muy temprano");
                        }
                        if (horas_control == 21 || horas_control == 22)
                        {
                            Console.WriteLine("Duermes a una buena hora, no hay nada que corregirte");
                        }
                        break;
                    case 2:
                        int N1 = 1, N2 = 10;
                        int oper = 1;
                        Console.WriteLine("Multiplicador del 1 al 10");
                        for (int i = N1; i <= N2; i++)
                        {
                            oper = oper * i;
                        }
                        Console.WriteLine("El resultado es: " + oper);
                        break;
                    case 3:
                        Console.WriteLine("Numero?");
                        int num, res;
                        num = int.Parse(Console.ReadLine());
                        res = num;
                        while (res != 1)
                        {
                            if (res % 2 == 0)
                            {
                                res = res / 2;
                                Console.WriteLine(res);
                            }
                            else
                            {
                                res = (res + 1) / 2;
                                Console.WriteLine(res);
                            }
                        }
                        break;
                }
                Console.WriteLine("Repetir programa, 1 para si, 0 para no");
                control=int.Parse(Console.ReadLine());  
            } while(control ==1);

        }
    }
}