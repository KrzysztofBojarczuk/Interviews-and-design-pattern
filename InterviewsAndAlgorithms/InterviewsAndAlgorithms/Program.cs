// See https://aka.ms/new-console-template for more information

using (var printCSV = new PrintCSV())
{
    //frees or resets unmanaged resources clears memory
}
public class Print : IDisposable
{
    public void Dispose()
    {
        Console.WriteLine("I am doing Print");
    }
}
public class PrintCSV : Print
{
    public void Dispose()
    {
        Console.WriteLine("I am doing PrintCSV");
    }
    public void PrintCSvMEthod()
    {
        Console.WriteLine("I am printing PrintCSvMEthod");
    }
}