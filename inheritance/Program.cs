// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Age me = new Age();
Name mainName = new Name();

mainName.SayName();
me.SayName();
public class Name
{
    public virtual void SayName()
    {
        Console.WriteLine("My name is Gwachukwu");
    }
}
public class Age : Name
{
    public override void SayName()
    {
        // base.SayName();
        Console.WriteLine("My name is Dade");
    }
}