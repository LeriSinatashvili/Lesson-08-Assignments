using System.Net.Http.Headers;
using System.Runtime.InteropServices;

public class Program
{

    public static void Main()
    {


        Student student = new Student();
        student.Name = "John";
        student.Age = 25;
        student.StudentId = 1234;
        student.DisplayInfo();
        student.Desctibe();

        Student student2 = new Student("Walter", 30);
        student2.DisplayInfo2();

        Console.WriteLine(student.GetOccupation());


        Teacher teacher = new Teacher();
        teacher.Name = "Peter";
        teacher.Age = 35;
        teacher.Subject = "Math";
        teacher.DisplayInfo();
        teacher.Desctibe();

        Teacher teacher2 = new Teacher("Simon", 45);
        teacher2.DisplayInfo2();

        Console.WriteLine(teacher.GetOccupation());


        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();




        Sword sword = new Sword { Name = "Excalibur", Damage = 25 };
        Bow bow = new Bow { Name = "Whispering", Damage = 35 };
        Axe axe = new Axe { Name = "Greataxe", Damage = 45 };


        Character characterMike = new Character();
        characterMike.Name = "Mike";
        characterMike.Health = 200;

        characterMike.Weapons.Add(sword);
        characterMike.Weapons.Add(bow);



        Character characterPeter = new Character();
        characterPeter.Name = "Peter";
        characterPeter.Health = 250;

        characterPeter.Weapons.Add(bow);
        characterPeter.Weapons.Add(axe);




        while (characterMike.Health > 0 && characterPeter.Health > 0)
        {

            characterMike.Hit(characterMike.Weapons[0], characterPeter);

            Console.WriteLine($"Peters health is {characterPeter.Health}");

            if (characterPeter.Health <= 0)
            {
                Console.WriteLine($"{characterMike.Name} wins!");

                break;
            }

            characterPeter.Hit(characterPeter.Weapons[1], characterMike);

            Console.WriteLine($"Mikes health is {characterMike.Health}");

            if (characterMike.Health <= 0)
            {
                Console.WriteLine($"{characterPeter.Name} wins!");

                break;
            }
        }

    }

}
