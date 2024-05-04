// See https://aka.ms/new-console-template for more information
void h()
{
    Console.WriteLine("ingrese un numero para validar si es perfecto");
    int n1 = Convert.ToInt16(Console.ReadLine());
    int sumaDivisores = 0;
    for (int i = 1; i < n1; i++)
    {
        if (n1 % i == 0)
        {
            sumaDivisores += i;
            {

            }
        }
    }
    if (sumaDivisores == n1)
    {
        Console.WriteLine($"el {n1} es perfecto.");
    }
    else
    {
        Console.WriteLine($"el {n1} No es perfecto");
    }
}
h();

