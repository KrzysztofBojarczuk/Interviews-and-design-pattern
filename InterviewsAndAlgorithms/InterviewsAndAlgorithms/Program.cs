// See https://aka.ms/new-console-template for more information


int[] tabl = new int[] { 1, 2, 3, 2 - 7, 44, 5, 1, 0 - 3 };

for (int i = 0; i < tabl.Length; i++)
{
    Console.WriteLine($"t{ "[" + tabl[i] + "]"} = " + $"{tabl[i]}");
}
Console.WriteLine("=================");
Search(tabl, 0,tabl.Length-1,7);
Search(tabl, 0,tabl.Length-1,5);


void Search(int[] tab, int left, int right, int x)
{
    if (left < right)
    {
        Console.WriteLine("Item not found: " + x);
    }
    else
    {
        if (tab[left] == x)
        {
            Console.WriteLine("Item found: " + x);
        }
        else
        {
            Search(tab, left + 1, right, x);
        }
    }
}
