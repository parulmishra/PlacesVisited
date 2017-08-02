using System;
using System.Collections.Generic;
namespace PlacesVisited.Models
{
    public class Contact
	{
		private string _name;
		private string _email;
		private string _phone;

		public Contact(string name, string email, string phone)
		{
			_name = name;
			_email = email;
			_phone = phone;
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
        private int _duration;
        private static List<Place> _places = new List<Place>{};
        private Contact _placeContact;

        public Place(string location, int duration, Contact placeContact)
        {
            _location = location;
            _duration = duration;
            _placeContact = placeContact;
        }
        public string GetLocation()
        {
            return _location;
        }
        public void SetLocation(string location)
        {
            _location = location;
        }
        public int GetDuration()
        {
            return _duration;
        }
        public void SetDuration(int duration)
        {
            _duration = duration;
        }
        public static List<Place> GetAll()
        {
            return _places;
        }
        public Contact GetContact()
        {
            return _placeContact;
        }
        public void Save()
        {
          _places.Add(this);
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
