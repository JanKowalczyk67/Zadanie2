namespace Zadanie2APBD;

public class ReportService
{
    public void GenerateReport(List<Equipment> equipment, List<Rental> rentals)
    {
        Console.WriteLine("=== REPORT ===");

        foreach (var e in equipment)
            Console.WriteLine($"{e.Name} | Available: {e.IsAvailable}");

        foreach (var r in rentals.Where(r => !r.IsReturned))
            Console.WriteLine($"{r.User.FirstName} -> {r.Equipment.Name}");
    }
}