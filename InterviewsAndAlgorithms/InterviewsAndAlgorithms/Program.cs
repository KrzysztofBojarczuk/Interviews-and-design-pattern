// See https://aka.ms/new-console-template for more information

int firstNumber = 0;
int secondNumber = 1;

for (int i = 2; i <= 10; i++)
{
    int result = firstNumber + secondNumber;
    firstNumber = secondNumber;
    secondNumber = result;
    Console.WriteLine(result);

}
Console.WriteLine("=====================");
for (int i = 1; i < 15; i++)
{
    Console.WriteLine($" {Fib(i)}");
}

static int Fib(int x)
{
    if (x < 2)
    {
        return x;
    }
    else
    {
        return Fib(x - 1) + Fib(x - 2);
    }
}
