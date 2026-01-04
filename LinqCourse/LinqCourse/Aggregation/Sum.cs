using LinqCourse.__Common__;

namespace LinqCourse.Aggregation;
public static class Sum
{
    public static void CallSum()
    {
        Console.WriteLine("***** Sum *****");
        CallSumSimple();
        CallSumComplex();
        Console.WriteLine("***** Sum *****");
    }

    private static void CallSumSimple()
    {
        var sum = Collections.SimpleCollection.Sum();
        Console.WriteLine($"[Simple] Sum of elements in collection is: {sum}.");
    }

    private static void CallSumComplex()
    {
        var sum = Collections.ComplexCollection.Sum(x => x.Age);
        Console.WriteLine($"[Complex] Sum of elements in collection is: {sum}.");

        var select = Collections.ComplexCollection.Select(x => x.Age).Sum();
        Console.WriteLine($"[Complex] Sum of elements in collection with SELECT is: {sum}.");
    }
}