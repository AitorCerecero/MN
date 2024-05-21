//int[][] the_max = new int[4][];
//the_max[0] = new int [4];
//the_max[1] = new int[4];
//the_max[2] = new int[4];
//the_max[3] = new int[4];

//the_max[2].lenght cantidad del renglon [r]
//the_max[

int profes;
int esculeas;

Console.WriteLine("En cuantas escuelas has estado?");
esculeas=int.Parse(Console.ReadLine());
String[][]academics_prof = new String[esculeas][];//para los profes


for (int i = 0; i < academics_prof.Length; i++)
{
    Console.WriteLine("Profes que has tenido en la escuela: " + (i+1));
    profes=int.Parse(Console.ReadLine());
    academics_prof[i] = new string[profes]; 
    for(int e = 0; e < academics_prof[i].Length; e++)
    {
        Console.WriteLine("Nombre del profe: " + (e + 1));
        academics_prof[i][e] = Console.ReadLine();
    }
}

for(int i = 0; i < academics_prof.Length; i++)
{
    for(int e = 0; e < academics_prof[i].Length; e++)
    {
        Console.WriteLine("Escuela: "+ i +" Profe: " + academics_prof[i][e]);
    }
}
Console.WriteLine();