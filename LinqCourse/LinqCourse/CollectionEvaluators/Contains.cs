using LinqCourse.__Common__;

namespace LinqCourse.CollectionEvaluators;

public static class ContainsLinq
{
    public static void CallContains()
    {
        Console.WriteLine("***** Contains *****");
        CallContainsSimple();
        CallContainsComplex();
        Console.WriteLine("***** Contains *****");
    }
    
    private static void CallContainsSimple()
    {
        var contains3 = Collections.SimpleCollection.Contains(3);
        Console.WriteLine($"Contains simple example 1: {contains3}");
        
        var contains10 = Collections.SimpleCollection.Contains(10);
        Console.WriteLine($"Contains simple example 2: {contains10}");
    }
    
    private static void CallContainsComplex()
    {
        var johnExists = Collections.ComplexCollection.Contains(new Person()
        {
            Name = "John",
            Age = 25,
            Interests = ["music", "art"]
        });
        
        Console.WriteLine($"Contains complex example 1: {johnExists}");
    }
}