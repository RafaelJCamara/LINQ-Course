
using LinqCourse.__Common__;

namespace LinqCourse.Projection;

public static class SelectLinq
{
    public static void CallSelect()
    {
        Console.WriteLine("***** Select *****");
        CallSelectSimple();
        CallSelectComplex();
        Console.WriteLine("***** Select *****");
    }
    
    private static void CallSelectSimple()
    {
        var doubledCollection = Collections.SimpleCollection.Select(number => number * 2);
        Console.WriteLine("Select simple example");
        foreach (var num in doubledCollection)
        {
            Console.WriteLine(num);
        }
    }
    
    private static void CallSelectComplex()
    {
        var personName = Collections.ComplexCollection.Select(person => person.Age);
        Console.WriteLine("Select complex example");
        foreach (var name in personName)
        {
            Console.WriteLine(name);
        }
    }
}