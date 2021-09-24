﻿using Moq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using TouristGuide.BusinessLayer.Interfaces;
using TouristGuide.BusinessLayer.Services;
using TouristGuide.BusinessLayer.Services.Repository;
using TouristGuide.Entities;
using Xunit;
using Xunit.Abstractions;

namespace TouristGuide.Test.TestCases
{
    public class FuctionalTests
    {
        /// <summary>
        /// Creating Referance Variable of Service Interface and Mocking Repository Interface and class
        /// </summary>
        private readonly ITestOutputHelper _output;
        private readonly ITourguideServices _TourServices;
        public readonly Mock<ITourguideRepository> service = new Mock<ITourguideRepository>();
        private readonly Place _place;
        private readonly Destination _destination;
        private readonly TourGuide _tourGuide;
        private readonly AboutIndia _aboutIndia;
        public FuctionalTests(ITestOutputHelper output)
        {
            //Creating New mock Object with value.
            _output = output;
            _TourServices = new TourguideServices(service.Object);
            _place = new Place()
            {
                PlaceId = 1,
                Name = "Delhi",
                Picture = "",
                Description = "With old monuments and busy neighbourhoods subtly merging with a vibrant and contemporary cosmopolitan world, Delhi, the capital of India, is a fascinating tourist destination. Poised along the banks of River Yamuna, Delhi, which is almost 1,000 years old,",
                Attraction = "India Gate, Red Fort, Akshardham, Jama Masjid",
                Experiences = "Heritage, Spritual, Food And Cuisine",
                Distance = 1,
                DestinationId = 1
            };
            _destination = new Destination()
            {
                DestinationId = 1,
                Name = "All Destinations",
                Url = "~/Tourist",
                OpenInNewWindow = false
            };
            _tourGuide = new TourGuide()
            {
                TourId = 1,
                Name = "Tour Operator Name",
                Phone = 9631438113,
                Email = "umakumarsingh@gmail.com",
                Address = "A-1, New Delhi",
                Experience = "7 Years",
                Remark = "Ok"
            };
            _aboutIndia = new AboutIndia()
            {
                Id = 1,
                About = "India is one of the oldest civilizations in the world with a kaleidoscopic variety and rich cultural heritage. It has achieved all-round socio-economic progress during the last 65 years of its Independence. India has become self-sufficient in agricultural production and is now one of the top industrialized countries in the world and one of the few nations to have gone into outer space to conquer nature for the benefit of the people. It covers an area of 32, 87,263 sq. km, extending from the snow-covered Himalayan heights to the tropical rain forests of the south. As the 7th largest country in the world, India stands apart from the rest of Asia, marked off as it is by mountains and the sea, which give the country a distinct geographical entity. Bounded by the Great Himalayas in the north, it stretches southwards and at the Tropic of Cancer, tapers off into the Indian Ocean between the Bay of Bengal on the east and the Arabian Sea on the west. As you travel, India offers a range of vast tourism choices, diverse in land and nature, people, tribes, cuisine, faiths, dance forms, music, arts, crafts, adventure, sport, spirituality, history; even these vary as you journey from one state to another. As a country, India has achieved all-round socio-economic progress in the last 70 years of independence. The change is clearly visible in the Tier I and Tier II cities. However, the fascinating aspect lies in the stark difference as you travel through the new and old parts of its cities. From world-class airports and hotels, luxurious shopping malls, restaurants, pubs and cafes to overcrowded streets and alleyways, in the same cities, filled with thousands of little shops offering every possible modern and ethnic product and native street food is a fascinating experience.",
                Visa = "All foreign nationals entering India are required to possess a valid international travel document in the form of a national passport with a valid visa obtained from an Indian Mission or Post abroad. Tourist Visa can only be granted to a foreigner who does not have a residence or occupation in India and whose sole objective of visiting India is recreation, sight seeing, casual visit to meet friends and relatives, etc.",
                Currency = "India Rupees",
                Language = "Hindi, English, Bengali, Marathi, Telugu, Tamil, Gujarati, Urdu, Kannada, Odia, Malayalam, Punjabi, Sanskrit",
                State = "Andhra Pradesh, Arunachal Pradesh, Assam, Bihar, Chhattisgarh, Goa, Gujarat, Haryana, Himachal Pradesh, Jharkhand, Karnataka, Kerala, Madhya Pradesh, Maharashtra, Manipur, Meghalaya, Mizoram, Nagaland, Odisha, Punjab, Rajasthan, Sikkim, Tamil Nadu, Telangana, Tripura, Uttar Pradesh, Uttarakhand, West Bengal.",
                UNION_TERRITORIES = "Andaman & Nicobar, Chandigarh, Dadra & Nagar Haveli, Daman & Diu, Delhi, Jammu & Kashmir, Ladakh, Lakshadweep, Puducherry",
                Climate = "SUMME, WINTER, RAINY, SPRING",
                How_Visit = "If you are from out of india, have a valid passport and visa., you can travel by air and train as well by road in india."
            };
        }
        /// <summary>
        /// Creating test output text file that store the result in boolean result
        /// </summary>
        static FuctionalTests()
        {
            if (!File.Exists("../../../../output_revised.txt"))
                try
                {
                    File.Create("../../../../output_revised.txt").Dispose();
                }
                catch (Exception)
                {

                }
            else
            {
                File.Delete("../../../../output_revised.txt");
                File.Create("../../../../output_revised.txt").Dispose();
            }
        }
        /// <summary>
        /// Testfor_Validate_Valid_HireTourGuide if all data is passed, cas is True
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_Valid_HireTourGuide()
        {
            //Arrange
            bool res = false;
            string testName;
            testName = TestUtils.GetCurrentMethodName();
            //Act
            try
            {
                service.Setup(repo => repo.HireTourGuide(_tourGuide)).ReturnsAsync(_tourGuide);
                var result = await _TourServices.HireTourGuide(_tourGuide);
                if (result != null)
                {
                    res = true;
                }
            }
            catch(Exception)
            {
                //Assert
                //final result save in text file if exception raised
                _output.WriteLine(testName + ":Failed");
                await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_Validate_Valid_HireTourGuide=" + res + "\n");
                return false;
            }
            //Assert
            //final result save in text file, Call rest API to save test result
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_Validate_Valid_HireTourGuide=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Using this test methd try to test and get all Place from Services and Repository method
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_GetAllPlaces()
        {
            //Arrange
            var res = false;
            string testName;
            testName = TestUtils.GetCurrentMethodName();
            //Action
            try
            {
                service.Setup(repos => repos.GetAllPlaces(_place.PlaceId));
                var result = await _TourServices.GetAllPlaces(_place.PlaceId);
                //Assertion
                if (result != null)
                {
                    res = true;
                }
            }
            catch(Exception)
            {
                //Assert
                //final result save in text file if exception raised
                _output.WriteLine(testName + ":Failed");
                await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_GetAllPlaces=" + res + "\n");
                return false;
            }
            //Assert
            //final result save in text file, Call rest API to save test result
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_GetAllPlaces=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Get Place by Id and try to get Place, if Passed Test True
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_GetPlaceById()
        {
            //Arrange
            var res = false;
            string testName;
            testName = TestUtils.GetCurrentMethodName();
            //Action
            try
            {
                service.Setup(repos => repos.GetPlaceById(_place.PlaceId)).ReturnsAsync(_place);
                var result = await _TourServices.GetPlaceById(_place.PlaceId);
                //Assertion
                if (result != null)
                {
                    res = true;
                }
            }
            catch(Exception)
            {
                //Assert
                //final result save in text file if exception raised
                _output.WriteLine(testName + ":Failed");
                await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_GetPlaceById=" + res + "\n");
                return false;
            }
            //Assert
            //final result save in text file, Call rest API to save test result
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_GetPlaceById=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Get place by Attraction and Name
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_PlaceByAttraction()
        {
            //Arrange
            var res = false;
            string testName;
            testName = TestUtils.GetCurrentMethodName();
            //Action
            try
            {
                service.Setup(repos => repos.PlaceByAttraction(_place.Attraction));
                var result = await _TourServices.PlaceByAttraction(_place.Attraction);
                //Assertion
                if (result != null)
                {
                    res = true;
                }
            }
            catch(Exception)
            {
                //Assert
                //final result save in text file if exception raised
                _output.WriteLine(testName + ":Failed");
                await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_PlaceByAttraction=" + res + "\n");
                return false;
            }
            //Assert
            //final result save in text file, Call rest API to save test result
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_PlaceByAttraction=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Get Detal of all Information
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_KnowAboutIndia()
        {
            //Arrange
            var res = false;
            string testName;
            testName = TestUtils.GetCurrentMethodName();
            //Action
            try
            {
                service.Setup(repos => repos.KnowAboutIndia());
                var result = await _TourServices.KnowAboutIndia();
                //Assertion
                if (result != null)
                {
                    res = true;
                }
            }
            catch(Exception)
            {
                //Assert
                //final result save in text file if exception raised
                _output.WriteLine(testName + ":Failed");
                await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_KnowAboutIndia=" + res + "\n");
                return false;
            }
            //Assert
            //final result save in text file, Call rest API to save test result
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_KnowAboutIndia=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Get list of Deatination
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_GetDestinationList()
        {
            //Arrange
            var res = false;
            string testName;
            testName = TestUtils.GetCurrentMethodName();
            //Action
            try
            {
                service.Setup(repos => repos.DestinationList());
                var result = _TourServices.DestinationList();
                //Assertion
                if (result != null)
                {
                    res = true;
                }
            }
            catch(Exception)
            {
                //Assert
                //final result save in text file if exception raised
                _output.WriteLine(testName + ":Failed");
                await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_GetDestinationList=" + res + "\n");
                return false;
            }
            //Assert
            //final result save in text file, Call rest API to save test result
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_GetDestinationList=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Get Tour Guide Information after hire Tour Guide
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_TourGuideInformation()
        {
            //Arrange
            var res = false;
            string testName;
            testName = TestUtils.GetCurrentMethodName();
            //Action
            try
            {
                service.Setup(repos => repos.TourGuideInformation(_tourGuide.TourId));
                var result = await _TourServices.TourGuideInformation(_tourGuide.TourId);
                //Assertion
                if (result != null)
                {
                    res = true;
                }
            }
            catch(Exception)
            {
                //Assert
                //final result save in text file if exception raised
                _output.WriteLine(testName + ":Failed");
                await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_TourGuideInformation=" + res + "\n");
                return false;
            }
            //Assert
            //final result save in text file, Call rest API to save test result
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_TourGuideInformation=" + res + "\n");
            return res;
        }
    }
}
