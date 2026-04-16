using HelloWorldAssignment18;

namespace HelloWorldAssignment18
{
    class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            Cars car1 = new Cars();
            Cars car2 = new Cars(2);
            Cars car3 = new Cars(3, "Toyota", 5000.90);

            Console.WriteLine("In car1 Id:{0} Make: {1} Price: {2}", car1.Id, car1.Make, car1.Price);
            Console.WriteLine("In car2 Id:{0} Make: {1} Price: {2}", car2.Id, car2.Make, car2.Price);
            car3.Price = 6000.99;
            Console.WriteLine("In car3 Id:{0} Make: {1} Price: {2}", car3.Id, car3.Make, car3.Price);
            Console.ReadLine();
        }
    }
}