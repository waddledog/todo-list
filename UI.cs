
// This UI class contains methods that are responisble for writing things to the user via the console
//
// Static means you don't have to create a new instance of this class, it will always exist when the program is running.
//
// The drawback of being static, is that everything that it only has access to things that are also static / exist at runtime.
internal static class UI
{
    // 'void' means that this method doesn't return anything.
    //
    // var output = UI.WriteHeader() will not work, because the return value is void.
    internal static void WriteHeader()
    {
        Console.WriteLine("---------");
        Console.WriteLine("| TO DO |");
        Console.WriteLine("---------");
        Console.WriteLine();
    }

    // 'string' means that this method returns a string object.
    //
    // var output = UI.WriteHeader() will assign the output variable with whatever is returned in this method.
    internal static string ReadOptionInput()
    {
        Console.Write("option: ");
        var input = Console.ReadLine();

        return input;
    }
}