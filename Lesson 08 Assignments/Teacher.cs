public class Teacher : Person
{
    public Teacher()
    {
        
    }

    public Teacher(string name, int age) : base()
    {
        this.Name = name;
        this.Age = age;
    }

    public string Subject { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Hello teacher with name {Name} with age {Age} and with subject {Subject}");
    }

    public void DisplayInfo2()
    {
        Console.WriteLine($"Hello teacher with name {Name} with age {Age}");
    }

    public override void Desctibe()
    {
        Console.WriteLine("I am a teacher.");
    }

    public override string GetOccupation()
    {
        return "Teacher";
    }

}
