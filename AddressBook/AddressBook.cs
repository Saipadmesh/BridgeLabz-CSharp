

namespace FirstProject
{
    public class AddressBook
    {
        List<Contact> contacts;
        public AddressBook() {
            contacts= new List<Contact>();
        }

        public List<Contact> GetList()
        {
            return contacts;
        }

        public void Add(Contact contact)
        {
            string firstName=contact.FirstName;
            if(!contacts.Where(contact1=>contact1.FirstName==firstName).Any())
            {
                contacts.Add(contact);
            }
            else
            {
                Console.WriteLine("Contact with same name exists");
            }
        }
        public void Remove(string firstName)
        {
            // UC4
            var toDeleteList = contacts.Where((contact) => contact.FirstName == firstName);
            if(toDeleteList.Any() )
            {
                contacts.Remove(toDeleteList.First());
            }
            else
            {
                Console.WriteLine("No contact with the given first name is found");
            }
        }
        public void Edit(string firstName, string phNo="", string address="", string city="", string state="")
        {
            var toEditList = contacts.Where((contact)=>contact.FirstName == firstName);
            if(toEditList.Any() )
            {
                Contact toEdit = toEditList.First();
                if (phNo.Length > 0)
                {
                    toEdit.Phone = phNo;
                }
                if (address.Length > 0)
                {
                    toEdit.Address = address;
                }
                if (city.Length > 0)
                {
                    toEdit.City = city;
                }
                if (state.Length > 0)
                {
                    toEdit.State = state;
                }
            }
            else
            {
                Console.WriteLine("Contact does not exist");
            }
        }
    }
}
