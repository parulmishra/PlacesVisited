using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PlacesVisited.Models;

namespace PlacesVisited.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet("/placelist")]
        public ActionResult PlaceList()
        {
            List<Place> places = Place.GetAll();
			
            return View(places);
        }

        [HttpGet("/placelist/{id}")]
        public ActionResult GetCurrentPlace(int id)
        {
            Place place = Place.Find(id);
			return View("CurrentPlace", place);
        }

        [HttpPost("/placelist/create")]
        public ActionResult CreatePlace()
        {
            Contact placeContact = new Contact(Request.Form["name"], Request.Form["email"], Request.Form["phone"], int.Parse(Request.Form["duration"]));

            Place newPlace = Place.Create(Request.Form["location"], placeContact);

            return View(newPlace);
        }

    }
}
