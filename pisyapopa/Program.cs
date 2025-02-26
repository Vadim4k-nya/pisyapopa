namespace pisyapopa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Teacher teacha1 = new Teacher("Mushinka", 38, 18, 2);
            Teacher teacha2 = new Teacher("Nika", 13, 9, 1);
            Student studeshka = new Student("Mihail", 15, 1, 23);

            Console.WriteLine(teacha1.GetInfo() + '\n');
            Console.WriteLine(teacha2.GetInfo() + '\n');
            Console.WriteLine(studeshka.GetInfo() + '\n');*/

            Bus bus = new Bus(2, 10, 15, 80);
            Trolleybus trolleybus = new Trolleybus(37, 37, 37, 1000);

            Console.WriteLine(bus.GetInfo() + $"\nТоплива хватит на {bus.FuelCalculation()}км\n");
            Console.WriteLine(trolleybus.GetInfo() + $"\nАкумулятора хватит на {trolleybus.AcumCalculation()}км\n");


        }
    }
}