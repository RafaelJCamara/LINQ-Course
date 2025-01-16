using LinqCourse.__Common__;

namespace LinqCourse.Filtering;

public static class WhereLinq
{
    public static void CallWhere()
    {
        Console.WriteLine("***** Where *****");
        CallWhereSimple();
        CallWhereComplex();
        Console.WriteLine("***** Where *****");
    }
    
    private static void CallWhereSimple()
    {
        var whereNumberGreaterThan3 = Collections.SimpleCollection.Where(number => number > 3);
        Console.WriteLine("Where simple example 1");
        foreach (var num in whereNumberGreaterThan3)
        {
            Console.WriteLine(num);
        }
        
        var whereNumberGreaterThan10 = Collections.SimpleCollection.Where(number => number > 10);
        Console.WriteLine("Where simple example 2");
        foreach (var num in whereNumberGreaterThan10)
        {
            Console.WriteLine(num);
        }
    }
    
    private static void CallWhereComplex()
    {
        // 1 - Filter for people that have an age greater than 30
        // 2 - Filter people that have more than one interest 
    }
}