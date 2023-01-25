

using System.Runtime.Serialization.Formatters.Binary;

namespace FirstProject
{
    public class AddressBook
    {
        List<Contact> contacts;
        Dictionary<string, List<Contact>> byState;
        Dictionary<string, List<Contact>> byCity;
        public AddressBook() {
            contacts= new List<Contact>();
            byCity= new Dictionary<string, List<Contact>>();
            byState= new Dictionary<string, List<Contact>>();
        }

        public List<Contact> GetList()
        {
            return contacts;
        }

        public void SetList(List<Contact> list)
        {
            contacts = list;
        }

        public void Add(Contact contact)
        {
            string firstName=contact.FirstName;
            string city = contact.City;
            string state = contact.State;
            if(!contacts.Where(contact1=>contact1.FirstName==firstName).Any()) // UC7
            {
                contacts.Add(contact);

                if (!byCity.ContainsKey(city))
                {
                    byCity[city] = new List<Contact>();
                }
                byCity[city].Add(contact);
                if(!byState.ContainsKey(state))
                {
                    byState[state] = new List<Contact>();
                }
                byState[state].Add(contact);
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

        public static List<Contact> Search(Dictionary<string,AddressBook> addresses, string toSearch, int option)
        {
            // UC8
            List<Contact> list = new List<Contact>();
            if(toSearch!= null)
            {
                if (option == 0)
                {
                    foreach(var addressBook in addresses.Values)
                    {
                        list.AddRange(addressBook.GetList().Where((contact)=>contact.City == toSearch));
                    }
                    return list;
                }
                else if (option == 1)
                {
                    foreach (var addressBook in addresses.Values)
                    {
                        list.AddRange(addressBook.GetList().Where((contact) => contact.State == toSearch));
                    }
                    return list;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("option");
                }
            }
            else
            {
                throw new ArgumentNullException("toSearch");
            }
            
        }

        public void ViewByState()
        {
            // UC9 and UC10
            int count;
            foreach(var state in byState)
            {
                count = 0;
                Console.WriteLine(state.Key+": ");
                foreach(var contact in state.Value)
                {
                    Console.WriteLine(contact.FirstName);
                    count++;
                }
                Console.WriteLine("Count: "+count);
                Console.WriteLine();
            }
        }

        public void ViewByCity()
        {
            // UC9 and UC10
            int count;
            foreach (var city in byCity)
            {
                Console.WriteLine(city.Key + ": ");
                count = 0;
                foreach (var contact in city.Value)
                {
                    count++;
                    Console.WriteLine(contact.FirstName);
                }
                Console.WriteLine("Count: "+count);
                Console.WriteLine();
            }
        }

        public override string ToString()
        {
            string toPrint = "[";
            foreach(var p in contacts)
            {
                toPrint += p.ToString()+",";
            }
            toPrint+= "]";
            return toPrint;
        }

        public static void PrintSortedByName(AddressBook addressBook)
        {
            // UC11
            addressBook.SetList(addressBook.contacts.OrderBy((contact) => contact.FirstName).ToList());
            Console.WriteLine(addressBook);
        }

        public static void PrintSortedByCity(AddressBook addressBook)
        {
            // UC12
            addressBook.SetList(addressBook.contacts.OrderBy((contact) => contact.City).ToList());
            Console.WriteLine(addressBook);
        }

        public static void PrintSortedByState(AddressBook addressBook)
        {
            // UC12
            addressBook.SetList(addressBook.contacts.OrderBy((contact) => contact.State).ToList());
            Console.WriteLine(addressBook);
        }

        public static void PrintSortedByPostalCode(AddressBook addressBook)
        {
            // UC12
            addressBook.SetList(addressBook.contacts.OrderBy((contact) => contact.PostalCode).ToList());
            Console.WriteLine(addressBook);
        }

        public static void WriteToFile(AddressBook addressBook, string fileName)
        {
            // UC13
            try
            {
                string path = @"C:\Users\223089657\Desktop\Learning\C#\TestFiles\" + fileName + ".txt";
                File.WriteAllText(path, addressBook.ToString());
                Console.WriteLine("File written successfully");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
