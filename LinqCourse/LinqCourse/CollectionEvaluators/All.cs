using LinqCourse.__Common__;

namespace LinqCourse.CollectionEvaluators;

public static class AllLinq
{
    public static void CallAll()
    {
        Console.WriteLine("***** All *****");
        CallAllSimple();
        CallAllComplex();
        Console.WriteLine("***** All *****");
    }
    
    private static void CallAllSimple()
    {
        var areAllBiggerThan3 = Collections.SimpleCollection.All(number => number > 3);
        Console.WriteLine($"All simple example 1: {areAllBiggerThan3}");
        
        var areAllBiggerThan0 = Collections.SimpleCollection.All(number => number > 0);
        Console.WriteLine($"All simple example 2: {areAllBiggerThan0}");
    }
    
    private static void CallAllComplex()
    {
        var ageBiggerThan21 = Collections.ComplexCollection.All(person => person.Age > 21);
        Console.WriteLine($"All complex example 1: {ageBiggerThan21}");
        
        var nameLengthGraterThan4 = Collections.ComplexCollection.All(person => person.Name.Length > 4);
        Console.WriteLine($"All complex example 2: {nameLengthGraterThan4}");
    }
}