using LinqCourse.__Common__;

namespace LinqCourse.Aggregation;
public static class Min
{
    public static void CallMin()
    {
        Console.WriteLine("***** Min *****");
        CallMinSimple();
        CallMinComplex();
        Console.WriteLine("***** Min *****");
    }

    private static void CallMinSimple()
    {
        var min = Collections.SimpleCollection.Min();
        Console.WriteLine($"[Simple] Min value: {min}");
    }

    private static void CallMinComplex()
    {
        var min = Collections.ComplexCollection.Min(x => x.Age);
        Console.WriteLine($"[Complex] Min value: {min}");
    }
}