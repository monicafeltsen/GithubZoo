namespace Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the magical GitZoo");

            List<Animal> animals = new List<Animal>();
            animals.Add(new Capybara("Barry", 55.2));
            animals.Add(new Ferret("Sotis", 0.5, "Monica"));
        }
    }
}