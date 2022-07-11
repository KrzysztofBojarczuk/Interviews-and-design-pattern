// See https://aka.ms/new-console-template for more information


using InterviewsAndAlgorithms.Singleton;

int[] tablica = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

Singleton object1 = Singleton.GetInstance();
Singleton object2 = Singleton.GetInstance();


if (object1 == object2)
{
    Console.WriteLine("There objects are the same");
}
else
{
    Console.WriteLine("There objects are different");
}

int val = 0;