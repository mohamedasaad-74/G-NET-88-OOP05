using assignment8.AbstractShipment.class1;
using assignment8.AbstractShipment.class2;
using assignment8.AbstractShipment.inhertance1;
using assignment8.AbstractShipment.inhertance2;
using assignment8.AbstractShipment.inhertance3;
using assignment8.AbstractShipment.interface1;
using assignment8.AbstractShipment.interface2;

namespace assignment8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1  Abstraction
            //a)  What is Abstraction in Object-Oriented Programming?
            //==============================
            //بيخلي تركيز الكود يوضح احنا بنعمل دا فين 
            //ويظهر لعالم الخارجي اللي هو بيقدمه دون الدخول في تفاصيل انا عملتها ازاي
            //=================================================

            //    b)  Why is abstraction considered one of the four pillars of OOP ?
            //لانه سهل ومبسط خصوصا في الاكواد الكبيره
            //بيحمين من الخطا في التفاصيل الداخليه لانه بيظر للمستخدم كصوره خارجيه 
            //======================================================================
            #endregion
            #region Q2  Abstract Classes vs. Interfaces

            //a)  What is the difference between an Abstract Class and an Interface?
            //================== Abstract==========================
            // fields يحتوي علي  
            //6 access modifiers يحتوي علي
            //constructor يحتوي علي
            //  one abstract الكلاس بيورث من   
            //==================== Interface=================
            //fields لا يحتوي علي
            //1 access modifiers يحتوي علي
            //constructor لا يحتوي علي
            //  multi interface الكلاس بيورث من

            //b)  When would you choose an Interface instead of an Abstract Class?
            //بستخدم الانترفيس لما يكون عندي نفس اكتر من كلاس عندهم نفس الصفه لكن بينفدوها بطرق مختلفه

            //c)  Can a class inherit from multiple abstract classes? Can it implement multiple interfaces?
            //  (NO) ========  one abstract الكلاس بيورث من
            // (YES) =======  multi interface الكلاس بيورث من








            #endregion

            #region part 2  Practical

            //DeliveryAddress address = new DeliveryAddress("Cairo", "El-Nasr Street", 15);

            //// a. Create one StandardShipment
            //StandardShipment standard = new StandardShipment("SH001", "Laptop", 2.0, 47.5m, address);

            //// b. Create one ExpressShipment
            //ExpressShipment express = new ExpressShipment("SH002", "Mobile Phone", 1.0, 70.0m, address, 30.0m);

            //// c. Create one InternationalShipment
            //InternationalShipment international = new InternationalShipment("SH003", "Documents", 0.7, 20.0m, address, 12.0m, "Germany");

            //// d. Add all shipments to the DeliveryCenter
            //DeliveryCenter center = new DeliveryCenter("Main Branch");
            //center.AddShipment(standard);
            //center.AddShipment(express);
            //center.AddShipment(international);

            //// e. Print all shipment details
            //Console.WriteLine("---------------------------------------------");
            //Console.WriteLine("Delivery Center  All Shipments");
            //Console.WriteLine("------------------------------------------");
            //center.PrintAllShipments();

            //// f. Print the tracking status of every shipment
            //Console.WriteLine("\n==================================================");
            //Console.WriteLine("Tracking Statuses");
            //Console.WriteLine("==================================================");
            //center.printTrackingStatus();

            //// g. Print the insurance cost of every shipment
            //Console.WriteLine("\n==================================================");
            //Console.WriteLine("Insurance Details");
            //Console.WriteLine("==================================================");
            //center.printInsuranceDetails();

            //// h. Store the shipment objects in an ITrackable[] array
            //ITrackable[] trackableItems = new ITrackable[] { standard, express, international };

            //// i. Store the shipment objects in an IInsurable[] array
            //IInsurable[] insurableItems = new IInsurable[] { standard, express, international };

            //Console.WriteLine("----------------------------------------------------");
            //Console.WriteLine("Interface Polymorphism Demonstrated Successfully.");
            //Console.WriteLine("--------------------------------------------");
        }
    }
}

            #endregion
        
    

