using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TouristGuide.BusinessLayer.Interfaces;
using TouristGuide.BusinessLayer.Services.Repository;
using TouristGuide.Entities;

namespace TouristGuide.BusinessLayer.Services
{
    public class TourguideServices : ITourguideServices
    {
        /// <summary>
        /// Creating referance variable of ITourguideRepository and injecting in TourguideServices constructor,
        /// using this varaible we are performing All CURD operation on TourguideRepository
        /// </summary>
        private readonly ITourguideRepository _tgRepository;
        public TourguideServices(ITourguideRepository tourguideRepository)
        {
            _tgRepository = tourguideRepository;
        }
        /// <summary>
        /// Show list of place and destination on Menu Bar
        /// </summary>
        /// <returns>List of Destination</returns>
        public IList<Destination> DestinationList()
        {
            var destination = _tgRepository.DestinationList();
            return destination;
        }
        /// <summary>
        /// Get Place by Destination id as well all placce on Index page of Tourist controller
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Place>> GetAllPlaces(int? Id)
        {
            var allplace = await _tgRepository.GetAllPlaces(Id);
            return allplace;
        }
        /// <summary>
        /// Get place details on clicking Continue reading link on place view
        /// </summary>
        /// <param name="placeId"></param>
        /// <returns></returns>
        public async Task<Place> GetPlaceById(int placeId)
        {
            var place = await _tgRepository.GetPlaceById(placeId);
            return place;
        }
        /// <summary>
        /// Hire a tour guide for better assistant while traveling
        /// </summary>
        /// <param name="tourGuide"></param>
        /// <returns></returns>
        public async Task<TourGuide> HireTourGuide(TourGuide tourGuide)
        {
            var tourguide = await _tgRepository.HireTourGuide(tourGuide);
            return tourguide;
        }
        /// <summary>
        /// Some quick information about india for visitor from InMemory Db
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<AboutIndia>> KnowAboutIndia()
        {
            var result = await _tgRepository.KnowAboutIndia();
            return result;
        }
        /// <summary>
        /// Place by Attraction tho show on while search in Db Collection
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Place>> PlaceByAttraction(string name)
        {
            var place = await _tgRepository.PlaceByAttraction(name);
            return place;
        }
        /// <summary>
        /// Show your some quick information and Tour Guide Booking Id
        /// </summary>
        /// <param name="tourId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<TourGuide>> TourGuideInformation(int tourId)
        {
            var result = await _tgRepository.TourGuideInformation(tourId);
            return result;
        }
    }
}
