namespace Zadanie2APBD;

public class RentalService
{
    private List<Rental> rentals = new();

    public void RentEquipment(User user, Equipment equipment, int days)
    {
        if (!equipment.IsAvailable)
            throw new Exception("Equipment not available");

        int active = rentals.Count(r => r.User == user && !r.IsReturned);

        if (active >= user.MaxRentals)
            throw new Exception("User exceeded rental limit");

        rentals.Add(new Rental
        {
            User = user,
            Equipment = equipment,
            RentDate = DateTime.Now,
            DueDate = DateTime.Now.AddDays(days)
        });

        equipment.IsAvailable = false;
    }

    public decimal ReturnEquipment(Equipment equipment)
    {
        var rental = rentals.FirstOrDefault(r => r.Equipment == equipment && !r.IsReturned);

        if (rental == null)
            throw new Exception("No active rental");

        rental.ReturnDate = DateTime.Now;
        equipment.IsAvailable = true;

        return CalculatePenalty(rental);
    }

    private decimal CalculatePenalty(Rental rental)
    {
        if (!rental.IsLate) return 0;
        int daysLate = (rental.ReturnDate.Value - rental.DueDate).Days;
        return daysLate * 10;
    }

    public List<Rental> GetAll() => rentals;
}