public static class PrimitiveTypes
{
    public static void Main()
    {
        Console.WriteLine("Learning Primitive Types in C#");
        // int32 - 32bit integer 2^n -1 = 2147483647 , -2^n -2147483648 max values
        int int32Number = 2;

        Console.WriteLine("int32 - 32bit integer 2^n -1 = 2147483647 , -2^n -2147483648 max values");
        Console.WriteLine($"int32Bit min value = {int.MinValue}");
        Console.WriteLine($"int32Bit max value = {int.MaxValue}");

        byte[] bytes = BitConverter.GetBytes(int32Number);

        foreach (byte b in bytes)
        {
            Console.WriteLine(Convert.ToString(b, 2).PadLeft(8, '0'));
        }
        Console.WriteLine($"int32Number = {int32Number}");

    }
}


// dotnet run --file PrimitiveTypes.cs
// output
// Learning Primitive Types in C#
// int32 - 32bit integer 2^n -1 = 2147483647 , -2^n -2147483648 max values
// int32Bit min value = -2147483648
// int32Bit max value = 2147483647
// 00000010
// 00000000
// 00000000
// 00000000
// int32Number = 2