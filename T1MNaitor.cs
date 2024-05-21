int a1, a2, a3;
Console.WriteLine("Valor 1");
a1 = int.Parse(Console.ReadLine());
Console.WriteLine("Valor 2");
a2 = int.Parse(Console.ReadLine());
Console.WriteLine("Valor 3");
a3 = int.Parse(Console.ReadLine());

int operator1 = a1 + a2 - a3;
Console.WriteLine("El resultado de la operacion 1 es " + operator1);

int operator2 = a1 * a2 * a3;
Console.WriteLine("El resultado de la operacion 2 es " + operator2);

int operator3 = a2 % a3;
Console.WriteLine("El residuo de la operacion 3 es " + operator3);

Boolean check;

//Comparacion 1
if (a1 == a3)
{
    check = true;
    Console.WriteLine("es igual");
}
else
{
    check = false;
    Console.WriteLine("No es igual");
}

//Comparacion 2
if (a1 >= a2 && a1 >= a3)
{
    check = true;
    Console.WriteLine("es mayor que");
}
else
{
    check = false;
    Console.WriteLine("No es mayor que");
}
//Comparacion 3
if (a1 == a3 || a1 >= a2 && a1 >= a3)
{
    check = true;
    Console.WriteLine("Se cumple");
}
else
{
    check = false;
    Console.WriteLine("No se cumple");
}

Console.WriteLine("Version 2");
int b1, b2;
Console.WriteLine("Valor 1");
b1 = int.Parse(Console.ReadLine());
Console.WriteLine("Valor 2");
b2 = int.Parse(Console.ReadLine());

int ops1 = b1 + b2;
Console.WriteLine("El resultado de operacion 1 es: " + ops1);

int ops2 = b2 * b1;
Console.WriteLine("El resultado de la operacion 2 es: " + ops2);

int ops3 = b1 % b2;
Console.WriteLine("El resultado de la operacion 3 es: " + ops3);

Boolean checker;

//Comparacion 1 V2
if (b1 == b2)
{
    checker = true;
    Console.WriteLine("Es igual");
}
else20
{
    checker = false;
    Console.WriteLine("No es igual");
}
//Comparacion 2 V2
if (b1 >= b2)
{
    checker = true;
    Console.WriteLine("Es mayor que");
}
else
{
    checker = false;
    Console.WriteLine("No es mayor que ");
}
//Comparacion 2 V2
if (b1 == b2 || b1 >= b2)
{
    checker = true;
    Console.WriteLine("Se cumple");
}
else
{
    checker = false;
    Console.WriteLine("No se cumple");
}