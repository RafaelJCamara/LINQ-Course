namespace LinqCourse.Projection;

public static class OfTypeLinq
{
    private static object?[] _ofTypeCollection = [null, true, "hello", 1, 2, "car"];
    public static void CallOfType()
    {
        Console.WriteLine("***** OfType *****");
        CallOfTypeNumber();
        CallOfTypeString();
        Console.WriteLine("***** OfType *****");
    }

    private static void CallOfTypeNumber()
    {
        var numbersCollection = _ofTypeCollection.OfType<int>();
        Console.WriteLine("OfType numbers example");
        foreach (var num in numbersCollection)
        {
            Console.WriteLine(num);
        }
    }
    
    private static void CallOfTypeString()
    {
        var stringsCollection = _ofTypeCollection.OfType<string>();
        Console.WriteLine("OfType strings example");
        foreach (var str in stringsCollection)
        {
            Console.WriteLine(str);
        }
    }
}