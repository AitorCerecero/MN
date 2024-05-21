internal class Program
{
    private static void Main(string[] args)
    {
        int control = 1;
        int op;
        do
        {
            Console.WriteLine("Actividad 12 y 13");
            Console.WriteLine("1. Rectangulos");
            Console.WriteLine("2. Trapecios");
            Console.WriteLine("3. Simpson");
            op = int.Parse(Console.ReadLine());

            if (op == 1)
            {
                double limInferior = -10, limSuperior = 10; // valores de entrada
                int partes = 1000; // definir # de partes, entre más grande más exacto
                double b, B, altura, area = 0;

                // calcular las bases
                b = limInferior;
                B = limSuperior;
                double LadoinferiorTrapecio = (B - b) / partes; //BASE

                // ciclo para calcular áreas
                for (double x = limInferior; x < limSuperior; x += LadoinferiorTrapecio)
                {
                    //Y = ALTURA2
                    double y = x + LadoinferiorTrapecio;
                    altura = Math.Sin(x) / x + 1; // ADAPTAR
                    area += LadoinferiorTrapecio * altura;
                }
                Console.WriteLine("El area es: " + area);
            }
            else if (op == 2)
            {
                double limInferior = -10, limSuperior = 10; //VALORES DE ENTRADA
                int partes = 1000; //DEFINIR # DE PARTES, ENTRE MAS GRANDE MAS EXACTO
                double baseRectangulo, altura, area = 0;

                //calcular la BASE
                baseRectangulo = (limSuperior - limInferior) / partes;

                //CICLO PARA CALCULAR AREAS
                for (double x = limInferior; x < limSuperior; x += baseRectangulo)
                {
                    altura = Math.Sin(x) / x + 1; //ADAPTAR
                    area += baseRectangulo * altura;
                }
                Console.WriteLine("El area es: " + area);

            }
            else if (op == 3)
            {

                double limInferior = -10, limSuperior = 10; //VALORES DE ENTRADA
                int partes = 1000; //DEFINIR # DE PARTES, ENTRE MAS GRANDE MAS EXACTO
                double baseSimpson, altura1, altura2, altura3, area = 0;

                //calcular la BASE
                baseSimpson = (limSuperior - limInferior) / partes;

                //CICLO PARA CALCULAR AREAS
                for (double x = limInferior; x < limSuperior;)
                {
                    altura1 = (Math.Sin(x)) / x + 1;
                    x += baseSimpson/2;
                    altura2 = (Math.Sin(x)) / x + 1;
                    x += baseSimpson / 2;
                    altura3 = (Math.Sin(x)) / x + 1;//ADAPTAR
                    area += ((altura1 + 4 * altura2 + altura3) / 6) * baseSimpson;
                    //////
                }
                Console.WriteLine("El area es: " + area);
            }
            Console.WriteLine("Repetir, 1 para si y 0 para no");
            control=int.Parse(Console.ReadLine());
        } while(control == 1);
    }
}