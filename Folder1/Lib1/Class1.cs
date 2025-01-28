using RestSharp;

namespace Lib1;

public class Class1
{
    public void Method1()
    {
        Console.WriteLine("Hello World!");
        
        var restClient = new RestClient("https://api.craftgate.io");
        
    }
}