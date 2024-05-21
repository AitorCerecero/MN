int a1, a2, a3, a4;

Console.WriteLine("Valor 1");
a1 = int.Parse(Console.ReadLine());
Console.WriteLine("Valor 2");
a2 = int.Parse(Console.ReadLine());
Console.WriteLine("Valor 3");
a3 = int.Parse(Console.ReadLine());
Console.WriteLine("Valor 4");
a4 = int.Parse(Console.ReadLine());

int operator_1 = a1 + a2 + a3 + a4;
Console.WriteLine(operator_1);

int operator_2 = a1- a2 + a3 -a4;
Console.WriteLine(operator_2);

int operator_3 = a1/ a2 / a3 / a4;
Console.WriteLine(operator_3);

int operator_4 = a1* a2 * a3* a4;
Console.WriteLine(operator_4);

Console.WriteLine("Comparadores");

Boolean check = true;

Console.WriteLine("Valor 1 es distinto a valor 3 ?");
if(a1 != a3)
{
    Console.WriteLine("Si es");
    check = false;
}
else
{
    Console.WriteLine("No es");
    check = true;
}

Console.WriteLine("Valor 2 es distinto a valor 4 ?");
if (a2 != a4)
{
    Console.WriteLine("Si es");
    check = false;
}
else
{
    Console.WriteLine("No es");
    check = true;
}

Console.WriteLine("Valor 1 es mayor que valor 3 o 4?");
if (a1 >= a3 || a4 > a1)
{
    Console.WriteLine("Si es");
    check = false;
}
else
{
    Console.WriteLine("No es");
    check = true;
}
Console.WriteLine("Valor 2 es distinto a verificacion de Valor 1 es mayor que valor 3 o 4?");
if (a2<a3)
{
    Console.WriteLine("Si es");
    check = false;
}
else
{
    Console.WriteLine("No es");
    check = true;
}
Console.WriteLine("La verificacion 1 y la verificacion 2 se cumplen");

if(a1!=a3 && a2 == a4)
{
    Console.WriteLine("Si es");
    check = false;
}
else
{
    Console.WriteLine("No es");
    check = true;
}
Console.WriteLine("La verificacion 3 y la verificacion 4 se cumplen");
if (a1 >= a3 || a4 > a1 || a2<a3)
{
    Console.WriteLine("Si es");
    check = false;
}
else
{
    Console.WriteLine("No es");
    check = true;
}


