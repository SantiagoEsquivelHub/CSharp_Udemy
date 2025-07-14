
partial class Program
{
    static void Inheritance()
    {
        HogwartsStudent student = new HogwartsStudent() { Name = "Harry Potter", House = "Gryffindor" };
        HogwartsProfessor professor = new HogwartsProfessor() { Name = "Severus Snape", Subject = "Potions" };

        student.Greet();
        student.ShowHouse();
        professor.Greet();
        professor.MySubject();

    }
}

class Character
{
    public string? Name { get; set; }
    public virtual void Greet()
    {
        WriteLine($"Hello, i'm {Name}");
    }
}

class HogwartsStudent : Character
{
    public string? House { get; set; }

    public override void Greet()
    {
        WriteLine($"Hello, i'm {Name} and i'm an student");
    }

    public virtual void ShowHouse()
    {
        WriteLine($"I belong to house {House} en Hogwarts");
    }
}

class HogwartsProfessor : Character
{
    public string? Subject { get; set; }

    public override void Greet()
    {
        WriteLine($"Hello, i'm {Name} and i'm a professor");
    }

    public void MySubject()
    {
        WriteLine($"I teach {Subject} in Hogwarts");
    }
}