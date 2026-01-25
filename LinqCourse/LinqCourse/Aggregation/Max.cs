using LinqCourse.__Common__;

namespace LinqCourse.Aggregation;
public static class Max
{
    public static void CallMax()
    {
        Console.WriteLine("***** Max *****");
        CallMaxSimple();
        CallMaxComplex();
        Console.WriteLine("***** Max *****");
    }

    private static void CallMaxSimple()
    {
        var max = Collections.SimpleCollection.Max();
        Console.WriteLine($"Max simple collection value: {max}");
    }

    private static void CallMaxComplex()
    {
        // Select max v1
        var ages = Collections.ComplexCollection.Select(person => person.Age);
        var maxAge = ages.Max();
        Console.WriteLine($"Max age with select> {maxAge}");

        // Select max v2
        var ageMax = Collections.ComplexCollection.Max(person => person.Age);
        Console.WriteLine($"Max age with max> {ageMax}");
    }
}