using LinqCourse.__Common__;

namespace LinqCourse.Sorting
{
    public static class OrderByDescendingLinq
    {
        public static void CallOrderByDescending()
        {
            Console.WriteLine("***** OrderByDescending *****");
            CallOrderByDescendingSimple();
            CallOrderByDescendingComplex();
            Console.WriteLine("***** OrderByDescending *****");
        }

        private static void CallOrderByDescendingSimple()
        {
            var orderedCollection = Collections.UnorderedSimpleCollection.OrderByDescending(x => x);
            Console.WriteLine($"Ordered collection descending: {string.Join(", ", orderedCollection)}");
        }

        private static void CallOrderByDescendingComplex()
        {
            var orderedCollection = Collections.ComplexCollection.OrderBy(x => x);
            Console.WriteLine("Ordered collection by Age descending:");
            foreach (var person in orderedCollection)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }
        }
    }
}
