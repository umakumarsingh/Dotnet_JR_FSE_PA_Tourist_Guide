using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TouristGuide.BusinessLayer.Interfaces;
using TouristGuide.BusinessLayer.ViewModels;
using TouristGuide.Entities;

namespace TouristGuide.Controllers
{
    public class TouristController : Controller
    {
        /// <summary>
        /// Creating referance variable of ITourguideServices and injecting in TouristController constructor
        /// </summary>
        private readonly ITourguideServices _tgServices;
        public TouristController(ITourguideServices tourguideServices)
        {
            _tgServices = tourguideServices;
        }
        /// <summary>
        /// Show all destination on Index page of Tourist Controller, user can find and navigate place by page also
        /// </summary>
        /// <param name="id"></param>
        /// <param name="search"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Index(int? id, string search, int page = 1)
        {
            if (search != null)
            {
                var intView = new PlaceViewModel
                {
                    PlacePerPage = 2,
                    Places = await _tgServices.PlaceByAttraction(search),
                    CurrentPage = page
                };
                return View(intView);
            }
            else
            {
                var intView = new PlaceViewModel
                {
                    PlacePerPage = 2,
                    Places = await _tgServices.GetAllPlaces(id),
                    CurrentPage = page
                };
                return View(intView);
            }
        }
        /// <summary>
        /// Get place full details using this method, on details view
        /// </summary>
        /// <param name="placeId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Details(int placeId)
        {
            var place = await _tgServices.GetPlaceById(placeId);
            return View(place);
        }
        /// <summary>
        /// Hire a tour Guide
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult HireTourGuide()
        {
            return View();
        }
        /// <summary>
        /// Post Method for Hire Tour Guide
        /// </summary>
        /// <param name="tourGuide"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> HireTourGuide(TourGuide tourGuide)
        {
            if (ModelState.IsValid)
            {
                TourGuide guide = new TourGuide
                {
                    Name = tourGuide.Name,
                    Phone = tourGuide.Phone,
                    Email = tourGuide.Email,
                    Experience = tourGuide.Experience,
                    Remark = tourGuide.Remark
                };
                var result = await _tgServices.HireTourGuide(tourGuide);
                return RedirectToAction("TourGuideInfo", "Tourist", new { tourId = result.TourId });
            }
            return View();
        }
        /// <summary>
        /// Tour Guide Infromation
        /// </summary>
        /// <param name="tourId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> TourGuideInfo(int tourId)
        {
            var tourGuide = await _tgServices.TourGuideInformation(tourId);
            return View(tourGuide);
        }
        /// <summary>
        /// Know about India Vist using this method
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> AboutIndia()
        {
            var about = await _tgServices.KnowAboutIndia();
            return View(about);
        }
        [HttpGet]
        public IActionResult ContactUs()
        {
            return View();
        }
    }
}
