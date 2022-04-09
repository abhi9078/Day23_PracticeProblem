using System;

namespace AddressBook
{

    class Contacts
    {
        
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string email { get; set; }
        public int zip { get; set; }
        public long phoneNumber { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBook problem");

            Records records = new Records();

            

            //Infinite Loop
            while (true)
            {
                Console.WriteLine("\nEnter 1 to Add person in AddressBook");
                Console.WriteLine("Enter 2 to Display all Contacts AdressBook");
                Console.WriteLine("Enter 3 to Display person list by city");
                Console.WriteLine("Enter 4 to Display person List by State");
                int choice=int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        records.AddRecord();
                        break;
                    case 2:
                        records.ToPrint();
                        break;
                    case 3:
                        records.CheckByCity();
                        break;
                    case 4:
                        records.CheckByState();
                        break;
                    default:
                        Console.WriteLine("Pleasee select valid input");
                        break;

                }

            }
        }
    }
}
