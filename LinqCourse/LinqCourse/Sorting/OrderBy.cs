using LinqCourse.__Common__;

namespace LinqCourse.Sorting;

public static class OrderByLinq
{
    public static void CallOrderBy()
    {
        Console.WriteLine("***** OrderBy *****");
        CallOrderBySimple();
        CallOrderByComplex();
        Console.WriteLine("***** OrderBy *****");
    }

    private static void CallOrderBySimple()
    {
        var orderedCollection = Collections.UnorderedSimpleCollection.OrderBy(x => x);
        Console.WriteLine($"Ordered collection: {string.Join(", ", orderedCollection)}");
    }

    private static void CallOrderByComplex()
    {
        var orderedCollection = Collections.ComplexCollection.OrderBy(x => x);
        Console.WriteLine("Ordered collection by Age:");
        foreach (var person in orderedCollection)
        {
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        }
    }
}