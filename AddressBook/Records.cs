using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Records
    {

        List<Contacts> records = new List<Contacts>();


        //Displaying all COntact of AddressBook
        public void ToPrint()
        {
            if (records.Count == 0)
            {
                Console.WriteLine("AddressBook is empty, please add some records or Address");
            }
            int reco = 1; 
            foreach (var person in records.ToList())
            {
                Console.WriteLine("\n\nRecord - " + reco);
                Console.WriteLine("First Name : " + person.firstName);
                Console.WriteLine("Last Name : " + person.lastName);
                Console.WriteLine("Address : " + person.address);
                Console.WriteLine("City : " + person.city);
                Console.WriteLine("State : " + person.state);
                Console.WriteLine("Email : " + person.email);
                Console.WriteLine("Zip code : " + person.zip);
                Console.WriteLine("Phone Number : " + person.phoneNumber);
                reco++;

            }
        }

        //Adding record to address book
        public void AddRecord()
        {
            Contacts contact = new Contacts();

           
                // adding new contact

                Console.WriteLine("Enter your First Name : ");
                contact.firstName = Console.ReadLine();
                Console.WriteLine("Enter your Last Name : ");
                contact.lastName = Console.ReadLine();
                Console.WriteLine("Enter your Address : ");
                contact.address = Console.ReadLine();
                Console.WriteLine("Enter your City Name : ");
                contact.city = Console.ReadLine();
                Console.WriteLine("Enter your State Name : ");
                contact.state = Console.ReadLine();
                Console.WriteLine("Enter your Zip Code : ");
                contact.zip = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your Phone Number : ");
                contact.phoneNumber = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Enter your Email Address: ");
                contact.email = Console.ReadLine();

                records.Add(contact);
            
            
        }

        //Sorting the Contacts name by Alphabetic Order
        public void SortContacts()
        {
            //Sorting and string in list
            List<Contacts> contacts = records.OrderBy(x => x.firstName).ToList();

            Console.WriteLine("Displaying Sorted Contact list in Alphabetic Order");
            int rc = 1;

            //Displaying List
            foreach (Contacts contact in contacts)
            {
                Console.WriteLine("\n\nRecord:-" + rc);
                Console.WriteLine("First name is: " + contact.firstName);
                Console.WriteLine("Last name is: " + contact.lastName);
                Console.WriteLine("Address : " + contact.address);
                Console.WriteLine("City : " + contact.city);
                Console.WriteLine("State : " + contact.state);
                Console.WriteLine("Email : " + contact.email);
                Console.WriteLine("Zip code : " + contact.zip);
                Console.WriteLine("Phone Number : " + contact.phoneNumber);
                rc++;
            }
        }
        
    }
}
