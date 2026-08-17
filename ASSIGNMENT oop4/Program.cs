namespace ASSIGNMENT_oop4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 

            // A) Abstraction is the concept of hiding unnecessary implementation details and showing only the essential features of an object to the user.

            // B) Abstraction is one of the four pillars of OOP because it reduces complexity by hiding unnecessary details and focusing on what an object does rather than how it does it. It also makes code easier to understand, maintain, and reuse.

            #endregion


            #region Q2


            // A) An Abstract Class can contain both abstract methods and concrete methods. It can also contain fields, constructors, and different access modifiers
            //  An Interface mainly defines a contract that a class must follow.It is used to specify behaviors that implementing classes should provide.


            // B) We choose an Interface when we want different or unrelated classes to share the same behavior or contract. It is also useful when a class needs to implement multiple behaviors. 


            //c) No, a class generally cannot inherit from multiple classes, including abstract classes, because languages such as Java and C# support single class inheritance.


            #endregion


            #region Practical



            Console.WriteLine("==========================================");
            Console.WriteLine("Delivery Center");
            Console.WriteLine("==========================================");
            Console.WriteLine();

            StandardShipment standardShipment = new StandardShipment(
                "SH001",
                "Laptop",
                9,
                50,
                new DeliveryAddress("Cairo", "Tahrir Street", 10)
            );

           
            ExpressShipment expressShipment = new ExpressShipment(
                "SH002",
                "Phone",
                4,
                50,
                new DeliveryAddress("Giza", "Pyramids Street", 20),
                30
            );

            
            InternationalShipment internationalShipment = new InternationalShipment(
                "SH003",
                "Documents",
                12,
                50,
                new DeliveryAddress("Fayoum", "Main Street", 15),
                "Germany",
                150
            );

            
            DeliveryCenter center = new DeliveryCenter();

            center.AddShipment(standardShipment);
            center.AddShipment(expressShipment);
            center.AddShipment(internationalShipment);

            
            center.PrintAllShipments();

            Console.WriteLine("==========================================");
            Console.WriteLine();
            Console.WriteLine("Tracking Status");
            Console.WriteLine();

           
            center.PrintTrackingStatuses();

            Console.WriteLine("==========================================");
            Console.WriteLine();
            Console.WriteLine("Insurance");
            Console.WriteLine();

            DeliveryReport report = new DeliveryReport();

          
            report.PrintInsurance(standardShipment);
            report.PrintInsurance(expressShipment);
            report.PrintInsurance(internationalShipment);

            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine();

         
            ITrackable[] trackableShipments =
            {
    standardShipment,
    expressShipment,
    internationalShipment
};

            foreach (ITrackable shipment in trackableShipments)
            {
                report.PrintShipment(shipment);
            }

            Console.WriteLine();

            IInsurable[] insurableShipments =
            {
    standardShipment,
    expressShipment,
    internationalShipment
};

            foreach (IInsurable shipment in insurableShipments)
            {
                report.PrintInsurance(shipment);
            }

            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine();
            Console.WriteLine("Interface Polymorphism Demonstrated Successfully.");


           
            #endregion

            
               












        }
    }
}
