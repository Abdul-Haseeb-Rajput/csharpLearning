// using System.Net.NetworkInformation;

internal class Program
{
    private static void Main(string[] args)
    {
        int number = 12;
        string name = "Abdul Haseeb";
        bool isActive = true;
        decimal taxPercentage = 0.12M;
        DateTime currentDate = DateTime.Now;


        // var
        var someVar = "A Haseeb";
        someVar = "TEST value change";
        // someVar = 23; compile time error (Not Allowed because datatype is decided by the compiler)


        // const 
        const double pi = 3.142;

        // pi = 123.12; (not allowed because its a constant.)


        Console.WriteLine(number);
        Console.WriteLine(name);
        Console.WriteLine(isActive);
        Console.WriteLine(taxPercentage);
        Console.WriteLine(currentDate);
        Console.WriteLine(someVar);
        Console.WriteLine(pi);

        // NullableTypes.Run();
    }
}


// dotnet run
// ===================== OUTPUT ==================
// 12
// Abdul Haseeb
// True
// 0.12
// 9/24/2026 1:41:33 PM
// TEST value change
// 3.142