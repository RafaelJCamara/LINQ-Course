using LinqCourse.__Common__;

namespace LinqCourse.Aggregation;
public static class Average
{
    public static void CallAverage()
    {
        Console.WriteLine("***** Average *****");
        CallAverageSimple();
        CallAverageComplex();
        Console.WriteLine("***** Average *****");
    }

    private static void CallAverageSimple()
    {
        var avg = Collections.SimpleCollection.Average();
        Console.WriteLine($"[Simple] Average result: {avg}");
    }

    private static void CallAverageComplex()
    {
        var avg = Collections.ComplexCollection.Average(x => x.Age);
        Console.WriteLine($"[Complex] Average result: {avg}");
    }
}