using Zadanie2APBD;

var equipmentService = new EquipmentService();
var userService = new UserService();
var rentalService = new RentalService();
var reportService = new ReportService();

var laptop = new Laptop("Dell XPS", 16, "i7");
var projector = new Projector("Epson", 3000, true);
var camera = new Camera("Canon", 24, true);

equipmentService.AddEquipment(laptop);
equipmentService.AddEquipment(projector);
equipmentService.AddEquipment(camera);

var student = new Student("Jan", "Kowalczyk");
var employee = new Employee("Anna", "Nowak");

userService.AddUser(student);
userService.AddUser(employee);

rentalService.RentEquipment(student, laptop, 1);

try
{
    rentalService.RentEquipment(student, projector, 1);
   // rentalService.RentEquipment(student, camera, 1);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

//rentalService.ReturnEquipment(laptop);
rentalService.ReturnEquipment(projector);


reportService.GenerateReport(equipmentService.GetAll(), rentalService.GetAll());
