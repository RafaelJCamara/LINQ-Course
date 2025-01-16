namespace LinqCourse.__Common__;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public List<string> Interests { get; set; }

    public override bool Equals(object? obj)
    {
        if (obj is Person person)
        {
            return Name == person.Name && Age == person.Age;
        }

        return false;
    }

    public override int GetHashCode() => HashCode.Combine(Name, Age);
}