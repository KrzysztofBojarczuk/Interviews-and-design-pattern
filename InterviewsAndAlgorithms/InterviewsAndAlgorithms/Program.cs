// See https://aka.ms/new-console-template for more information


int number = 1;

int n = 6;
for (int i = 1; i <= n; i++)
{
    number = number * i;
}

Console.WriteLine($"Factorial of {n} is: {number}" );