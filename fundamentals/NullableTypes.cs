public static class NullableTypes
{
    public static void Main()
    {
        Console.WriteLine("Learning Nullable Types");
        int age = 23;
        int? nullableAge = 50;
        string name = "Abdul Haseeb";
        string? nullableName = null;

        Console.WriteLine(age);
        Console.WriteLine(nullableAge.ToString());
        Console.WriteLine(name);
        Console.WriteLine(nullableName);

        if (nullableAge != null)
        {
            // string interpolation
            // string message = $"Hello, my name is {name} and I am {nullableAge} years old.";
            Console.WriteLine($"Hello!!! my name is {name} and age is {nullableAge}");
        }
        {

        }
    }
}


// ============== OUTPUT ==============
// Learning Nullable Types
// 23
// 50
// Abdul Haseeb
// null
// Hello!!! my name is Abdul Haseeb and age is 50