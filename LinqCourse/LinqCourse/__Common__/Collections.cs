namespace LinqCourse.__Common__;

public static class Collections
{
    public static int[] SimpleCollection = [1, 2, 3, 4, 5];

    public static int[] UnorderedSimpleCollection = [3, 2, 1, 5, 4];

    public static Person[] ComplexCollection =
    [
        new Person()
        {
            Name = "John",
            Age = 25,
            Interests = ["music", "art"]
        },
        new Person()
        {
            Name = "Rita",
            Age = 41,
            Interests = ["walking", "tv"]
        },
        new Person()
        {
            Name = "Ruth",
            Age = 37,
            Interests = ["politics"]
        },
        new Person()
        {
            Name = "Josh",
            Age = 37,
            Interests = ["surf", "music"]
        },
    ];
}