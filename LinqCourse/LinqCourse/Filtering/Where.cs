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
        var elementsBiggerThan3 = Collections.SimpleCollection.Where(number => number > 3);
        Console.WriteLine("Where simple example 1");
        foreach (var num in elementsBiggerThan3)
        {
            Console.WriteLine(num);
        }
        
        var elementsBiggerThan10 = Collections.SimpleCollection.Where(number => number > 10);
        Console.WriteLine("Where simple example 2");
        foreach (var num in elementsBiggerThan10)
        {
            Console.WriteLine(num);
        }
    }
    
    private static void CallWhereComplex()
    {
        var peopleWithAgeBiggerThan30 = Collections.ComplexCollection.Where(person => person.Age > 30);
        Console.WriteLine("Where complex example 1");
        foreach (var person in peopleWithAgeBiggerThan30)
        {
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
        }
    }
}