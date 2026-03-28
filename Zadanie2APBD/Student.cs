namespace Zadanie2APBD;

public class Student : User
{
    public override int MaxRentals => 2;

    public Student(string firstName, string lastName) : base(firstName, lastName) { }
}