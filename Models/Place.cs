using System;
using System.Collections.Generic;
namespace PlacesVisited.Models
{
    public class Contact
	{
		private string _name;
		private string _email;
		private string _phone;
		private int _duration;
		
		public Contact(string name, string email, string phone, int duration)
		{
			_name = name;
			_email = email;
			_phone = phone;
			_duration = duration;
		}
		public int GetDuration()
        {
            return _duration;
        }
		public string GetName()
		{
			return _name;
		}
		public string GetEmail()
		{
			return _email;
		}
		public string GetPhone()
		{
			return _phone;
		}
	}
    public class Place
    {
        private string _location;
        private int _id;
		private List<Contact> _contacts = new List<Contact>();
        private static List<Place> _places = new List<Place>();

        private Place(string location, Contact contact)
        {
            _location = location;
            _places.Add(this);
            _id = _places.Count;
			_contacts.Add(contact);
        }
		public static Place Create(string location, Contact contact)
		{
			foreach(var place in _places)
			{
				if(place.GetLocation() == location)
				{
					place.AddContact(contact);
					return place;
				}
			}
			return new Place(location, contact);
		}
		public void AddContact(Contact contact)
		{
			_contacts.Add(contact);
		}
		public List<Contact> GetContacts()
		{
			return _contacts;
		}
        public string GetLocation()
        {
            return _location;
        }
        public void SetLocation(string location)
        {
            _location = location;
        }
        public int GetId()
        {
            return _id;
        }
        public static List<Place> GetAll()
        {
            return _places;
        }
        public static Place Find(int searchId)
        {
            return _places[searchId-1];
        }
        // public string GetMessage()
        // {
        //     string str1 = "bad place";
        //     string str2 = "good place";
        //     if(_location == "seattle")
        //     {
        //         return str1;
        //     }
        //     else
        //     {
        //         return str2;
        //     }
        //}
    }
}
