namespace A4TMNAitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Actividad 4");
            Console.WriteLine("Programa 1");
            Console.WriteLine("Programa 2");
            Console.WriteLine("Programa 3");
            int op; 
            op = int.Parse(Console.ReadLine()); 

            switch (op) {

                case 1:
                    {
                        
                        for(int i = 1; i <= 1000; i++)
                        {
                            if (i == 2 || i == 3 || i == 5)
                            {
                                Console.WriteLine(i + "\t");
                            }
                            else if (i % 2 != 0 && i % 3 !=0&&i%5 !=0) {

                            }
                                
                        }
                        
                        break;
                    }
                case 2:
                    {
                        double i = 0;
                        double ans = 0;
                        while (ans <= 30)
                        {
                            i++;
                            ans=(Math.Pow(i, 2) -3) / i;
                        }
                        Console.WriteLine("Resultado: "+ans);
                        break;
                    }
                case 3:
                    {
                        int n = 3;
                        int counter = 0;
                        int max = 0;
                        int moda = 0; 
                        int prom = 0;
                        int total = 0;
                        while (n !=0)
                        {
                            Console.WriteLine("Numero menor que 50");
                            n = int.Parse(Console.ReadLine());
                            if (n >= 50)
                            {
                                Console.WriteLine("No validos");
                                n = 3;
                                
                            }
                            if (n > max)
                            {
                                max = n;
                            }
                            else
                            {
                                counter++;
                                total += n;
                                moda += n;
                            }

                        }
                        moda /= counter;
                        prom = (int)total /counter;
                        Console.WriteLine("Promedio: "+prom);
                        Console.WriteLine("Moda: "+moda);
                        Console.WriteLine("Numero mas grande: "+max);
                        break;
                    }

            }
        }
    }
}