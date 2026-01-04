using LinqCourse.__Common__;

namespace LinqCourse.Aggregation;
public static class Count
{
    public static void CallCount()
    {
        Console.WriteLine("***** Count *****");
        CallCountSimple();
        CallCountComplex();
        Console.WriteLine("***** Count *****");
    }

    private static void CallCountSimple()
    {
        var count = Collections.SimpleCollection.Count();
        Console.WriteLine($"[Simple] Number of elements with Count: {count}");
    }

    private static void CallCountComplex()
    {
        var count = Collections.SimpleCollection.Count(num => num > 3);
        Console.WriteLine($"[Predicate] Number of elements that pass the predicate with Count: {count}");

        var count2 = Collections.SimpleCollection.Count(num => num > 10);
        Console.WriteLine($"[Predicate2] Number of elements that pass the predicate with Count: {count2}");
    }
}