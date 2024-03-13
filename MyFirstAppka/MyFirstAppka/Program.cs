// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

//fasting solution

// homo sum et nihil homonium a me alienum ese puto

static double getAvarage(int[] lista)
{
    double result1=0;
    for (int i = 0; i < lista.Length; i++)
    {
        result1 += lista[i];
    }

    return result1 / lista.Length;
}
int[] paluszki = { 1, 5, 7, 8, 1234, 6, 2, 5, 2, 1, 4 };
double cosik = getAvarage(paluszki);
Console.WriteLine(cosik);