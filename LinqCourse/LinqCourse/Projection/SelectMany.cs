using LinqCourse.__Common__;

namespace LinqCourse.Projection;

public static class SelectManyLinq
{
    public static void CallSelectMany()
    {
        Console.WriteLine("***** SelectMany *****");
        CallSelectManyComplex();
        Console.WriteLine("***** SelectMany *****");
    }
    
    private static void CallSelectManyComplex()
    {
        var interestArray = Collections.ComplexCollection.SelectMany(person => person.Interests);
        foreach (var i in interestArray)
        {
            Console.WriteLine(i);
        }
    }
}