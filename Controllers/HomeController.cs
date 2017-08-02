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
        [HttpPost("/placelist/create")]
        public ActionResult CreatePlace()
        {
            Contact placeContact = new Contact(Request.Form["name"], Request.Form["email"], Request.Form["phone"]);

            Place newPlace = new Place(Request.Form["location"], Int32.Parse(Request.Form["duration"]), placeContact);

            newPlace.Save();
            return View(newPlace);
        }

    }
}
