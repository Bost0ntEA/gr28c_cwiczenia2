// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

//fasting solution

// homo sum et nihil homonium a me alienum ese puto

static double getAvarage(int[] lista)
{
    double result=0;
    for (int i = 0; i < lista.Length; i++)
    {
        result += lista[i];
    }

    return result / lista.Length;
}
int[] paluszki = { 1, 5, 7, 8, 1234, 6, 2, 5, 2, 1, 4 };
double cosik = getAvarage(paluszki);
Console.WriteLine(cosik);

static int getMax(int[] tab)
{
    int max = tab[0];
    for (int i = 1; i < tab.Length; i++)
    {
        if (tab[i]>max)
        {
            max = tab[i];
        }
    }

    return max;
}

int[] mojaablica = {1,6,8,3,12,6,1,2,1,12};
Console.WriteLine(getMax(mojaablica));
Console.WriteLine();
