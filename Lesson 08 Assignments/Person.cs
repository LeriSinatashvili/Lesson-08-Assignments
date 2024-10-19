public abstract class Person
{
    public Person()
    {
        
    }
    public Person(string name, int age)
    {
    }

    public string Name { get; set; }
    public int Age { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Hello person {Name} with age {Age}");
    }

    public virtual void Desctibe()
    {
        Console.WriteLine("I am a person.");
    }

    public abstract string GetOccupation();

}
