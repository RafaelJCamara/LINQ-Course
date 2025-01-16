using LinqCourse.__Common__;

namespace LinqCourse.CollectionEvaluators;

public static class AnyLinq
{
    public static void CallAny()
    {
        Console.WriteLine("***** Any *****");
        CallAnySimple();
        CallAnyComplex();
        Console.WriteLine("***** Any *****");
    }
    
    private static void CallAnySimple()
    {
        var isBiggerThan3 = Collections.SimpleCollection.Any(number => number > 3);
        Console.WriteLine($"Any simple example 1: {isBiggerThan3}");
        
        var isBiggerThan10 = Collections.SimpleCollection.Any(number => number > 10);
        Console.WriteLine($"Any simple example 2: {isBiggerThan10}");
    }
    
    private static void CallAnyComplex()
    {
        var ageBiggerThan40 = Collections.ComplexCollection.Any(person => person.Age > 40);
        Console.WriteLine($"Any complex example 1: {ageBiggerThan40}");
        
        var nameIsRichard = Collections.ComplexCollection.Any(person => person.Name == "John");
        Console.WriteLine($"Any complex example 2: {nameIsRichard}");
    }
}