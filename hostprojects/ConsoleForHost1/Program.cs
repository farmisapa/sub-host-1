using ModuleALibrary;

namespace ConsoleForHost1;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var host1Class1 = new HostClassLibrary.Host1Class1();
        Console.WriteLine(host1Class1.GetData());
        var a = new ModuleAClass1();
        Console.WriteLine(a.GetData());
    }
}