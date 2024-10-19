public class Student : Person
{

    public Student()
    {
    }
    public Student(string name, int age) : base()
    {
        this.Name = name;
        this.Age = age;
    }

    public int StudentId { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Hello student with name {Name} with age {Age} and with student ID {StudentId}");
    }

    public void DisplayInfo2()
    {
        Console.WriteLine($"Hello student with name {Name} with age {Age}");
    }

    public override void Desctibe()
    {
        Console.WriteLine("I am a student.");
    }

    public override string GetOccupation()
    {
        return "Student";
    }

}
