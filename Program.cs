namespace FirstProject
{


    internal class Program
    {
        static void Main(string[] args)
        {
            AddressBook addressBook1 = new AddressBook();
            Dictionary<string,AddressBook> addresses = new Dictionary<string,AddressBook>();

            addressBook1.Add(new Contact("Sai", "Padmesh", "Sivaram Nagar", "Coimbatore", "Tamil Nadu", "641045", "8072669384", "saipadmesh@gmail.com"));
            addressBook1.Add(new Contact("Ram", "Mohan", "Sivaram Nagar", "Chennai", "Tamil Nadu", "641045", "9042143893", "ramm@gmail.com"));
            //addressBook1.Add(new Contact("Ram", "Mohan", "Sivaram Nagar", "Coimbatore", "Tamil Nadu", "641045", "9042143893", "ramm@gmail.com"));
            addressBook1.Edit("Ram", phNo: "123456789");
            addresses.Add("addressBook1", addressBook1);
            AddressBook addressBook2 = new AddressBook();
            addressBook2.Add(new Contact("Ramesh", "Padmanabhan", "Shanti Colony", "Bangalore", "Karnataka", "641045", "8072669384", "saipadmesh@gmail.com"));
            addressBook2.Add(new Contact("Lokesh", "Sekhar", "Anna Nagar", "Chennai", "Tamil Nadu", "641045", "9042143893", "ramm@gmail.com"));
            addresses.Add("addressBook2", addressBook2);
            try
            {
                var results = AddressBook.Search(addresses, "Chennai", 0);
                foreach (var contact in results)
                {
                    Console.WriteLine(contact.FirstName);
                }
                Console.WriteLine();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            addressBook1.ViewByCity();
            
        }

    }
}