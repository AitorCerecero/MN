namespace T2MNaitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float n;
            Console.WriteLine("Numero");
            n=float.Parse(Console.ReadLine());

            if (n%1==0) 
            {
                Console.WriteLine("Es entero");
                for(int i = 2; i < n; i++)
                {
                    if ((n % i) == 0)
                    {
                        Console.WriteLine("No es primo");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Es Primo");
                        break;
                    }
                }
              
                
            }
            else if (n % 1 != 0){
                Console.WriteLine("Es fraccion");
            }
        }
    }
}