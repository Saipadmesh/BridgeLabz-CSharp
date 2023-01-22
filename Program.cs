namespace FirstProject
{


    internal class Program
    {
        static void Main(string[] args)
        {
            AddressBook addressBook = new AddressBook();

            addressBook.Add(new Contact("Sai", "Padmesh", "Sivaram Nagar", "Coimbatore", "Tamil Nadu", "641045", "8072669384", "saipadmesh@gmail.com"));
            addressBook.Add(new Contact("Ram", "Mohan", "Sivaram Nagar", "Coimbatore", "Tamil Nadu", "641045", "9042143893", "ramm@gmail.com"));
            //addressBook.Add(new Contact("Ram", "Mohan", "Sivaram Nagar", "Coimbatore", "Tamil Nadu", "641045", "9042143893", "ramm@gmail.com"));
            addressBook.Edit("Ram", phNo: "123456789");
            foreach (var contact in addressBook.GetList())
            {
                Console.WriteLine(contact.Phone);
            }
            addressBook.Remove("Ram");
        }

    }
}