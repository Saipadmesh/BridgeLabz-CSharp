using System;

namespace FirstProject;
public class Contact
{
	public string FirstName; 
	public string LastName;
	public string Address; 
	public string City;
	public string State;
	public string PostalCode;  
	public string Phone;
	public string Email;
	
	public Contact(string firstName, string lastName, string address, string city, string state, string postcalCode, string phone, string email)
	{
		FirstName = firstName;
		LastName = lastName;
		Address = address;
		City = city;
		State = state;
		PostalCode = postcalCode;
		Phone = phone;
		Email = email;
	}
}
