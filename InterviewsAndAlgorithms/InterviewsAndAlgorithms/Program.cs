// See https://aka.ms/new-console-template for more information


for (int i = 2; i < 100; i++)
{
    if (LiczbyPierwsze(i))
    {
        Console.WriteLine("Liczba pierwsza: " + i + " jest pierwsza");
    }
}

bool LiczbyPierwsze(int a)
{
    if (a <= 2)
    {
        return false;
    }

    for (int i = 2; i <= Math.Sqrt(a); i++)
    {
        if (a % i == 0)
        {
            return false;
        }

    }
    return true;
}
