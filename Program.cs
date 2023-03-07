using EventManagement;

internal class Program
{
    public static void Main(string[] args)
    {
        //DateTime date = DateTime.Now;
        Event e = new Event("Disco", new DateTime(2023, 05, 29), "Baybay", 100, 20000) ;
        Manager m = new Manager("Pat", "@mail", "019283");
        Location l = new Location("Resort", 500, Availability.Available);

        Customer c = new Customer("Lorenz", "sdfsdf", 45, 10000, 5);


    }
}