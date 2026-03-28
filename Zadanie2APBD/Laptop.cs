namespace Zadanie2APBD;

public class Laptop : Equipment
{
    public int RamGb { get; set; }
    public string Cpu { get; set; }

    public Laptop(string name, int ram, string cpu) : base(name)
    {
        RamGb = ram;
        Cpu = cpu;
    }
}