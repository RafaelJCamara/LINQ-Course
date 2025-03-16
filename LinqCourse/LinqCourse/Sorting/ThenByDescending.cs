using LinqCourse.__Common__;

namespace LinqCourse.Sorting
{
    public static class ThenByDescendingLinq
    {
        public static void CallThenByDescending()
        {
            Console.WriteLine("***** ThenByDescending *****");
            CallThenByDescendingComplex();
            Console.WriteLine("***** ThenByDescending *****");
        }

        private static void CallThenByDescendingComplex()
        {
            var orderedCollection = Collections.ComplexCollection
                .OrderBy(x => x)
                .ThenByDescending(x => x.Interests.Count)
                .ThenBy(x => x.Name.Length);

            Console.WriteLine("Ordered collection by Age:");
            foreach (var person in orderedCollection)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }
        }
    }
}
