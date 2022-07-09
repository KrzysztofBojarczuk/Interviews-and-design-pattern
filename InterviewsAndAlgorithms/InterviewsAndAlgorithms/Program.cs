// See https://aka.ms/new-console-template for more information


int[] tablica = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

string name = "Tomek";


for (int i = tablica.Length - 1; i >= 0; i--)
{
    Console.Write(tablica[i]);
}


char[] reverse = name.ToCharArray();

var reverseName = reverse.Reverse();

foreach (var item in reverseName)
{
    Console.Write(item);
}