using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DbDataLibrary.Models;
using lab2.ViewModels;

namespace lab2.Controllers
{
    public class MainController : Controller
    {
        static List<Client> ClientsArr = new List<Client>();
        static string Year = "All";

        static List<Tour> ToursArr = new List<Tour>();
        static string TourKindName = "All";

        static List<TourKind> TourKindsArr = new List<TourKind>();
        static string Name = "All";

        [HttpGet]
        public IActionResult Clients(string Year = "")
        {
            if(Year != "")
                MainController.Year = Year;

            return View(new ClientViewModel { Clients = MainController.ClientsArr,
                SelectedYear = MainController.Year });
        }

        [HttpPost]
        public IActionResult Clients(Client client)
        {
            ClientsArr.Add(client);
            return RedirectToAction("Clients");
        }

        [HttpGet]
        public IActionResult TourKinds(string Name = "")
        {
            if (Name != "")
                MainController.Name = Name;

            return View(new TourKindViewModel
            {
                TourKinds = MainController.TourKindsArr,
                SelectedName = MainController.Name
            });
        }

        [HttpPost]
        public IActionResult TourKinds(TourKind tourKind)
        {
            TourKindsArr.Add(tourKind);
            return RedirectToAction("TourKinds");
        }

        [HttpGet]
        public IActionResult Tours(string TourKind = "")
        {
            if (TourKind != "")
                MainController.TourKindName = TourKind;

            return View(new TourViewModel
            {
                Tours = MainController.ToursArr,
                SelectedName = MainController.TourKindName
            });
        }

        [HttpPost]
        public IActionResult Tours(Tour tour)
        {
            ToursArr.Add(tour);
            return RedirectToAction("Tours");
        }

        [HttpGet]
        public IActionResult Index()
        {
           return Redirect("~/index.html");
        }
    }
}