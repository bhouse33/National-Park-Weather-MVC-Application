using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Web.DAL;
using WebApplication.Web.Models;

namespace WebApplication.Web.Controllers
{
    public class SurveyController : Controller
    {
        private ISurveyDAO surveyDao;
        private IParkDAO parkDao;

        public SurveyController(ISurveyDAO surveyDao, IParkDAO parkDao)
        {
            this.parkDao = parkDao;

            this.surveyDao = surveyDao;
        }

        /// <summary>
        /// Returns all surveys grouped by park code and orders the parks from most surveys submitted to least
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Index()
        {
            IList<Park> parks = this.parkDao.GetParks();
            foreach (Park park in parks)
            {
                IList<Survey> surveys = this.surveyDao.GetSurveys(park.ParkCode);
                park.Surveys = surveys;
            }

            var orderList = parks.OrderBy(s => s.Surveys.Count).ToList();
            orderList.Reverse();

            return this.View(orderList);
        }

        /// <summary>
        /// Takes user to page to submit a new survey
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult NewSurvey()
        {
            IList<Park> parks = this.parkDao.GetParks();
            this.ViewData["parks"] = parks;

            IList<string> states = new List<string>()
            {
            "Alabama",
            "Alaska",
            "Arizona",
            "Arkansas",
            "California",
            "Colorado",
            "Connecticut",
            "Delaware",
            "Florida",
            "Georgia",
            "Hawaii",
            "Idaho",
            "Illinois",
            "Indiana",
            "Iowa",
            "Kansas",
            "Kentucky",
            "Louisiana",
            "Maine",
            "Maryland",
            "Massachusetts",
            "Michigan",
            "Minnesota",
            "Mississippi",
            "Missouri",
            "Montana",
            "Nebraska",
            "Nevada",
            "New Hampshire ",
            "New Jersey",
            "New Mexico",
            "New York",
            "North Carolina",
            "North Dakota",
            "Ohio",
            "Oklahoma",
            "Oregon",
            "Pennsylvania",
            "Rhode Island",
            "South Carolina",
            "South Dakota",
            "Tennessee",
            "Texas",
            "Utah",
            "Vermont",
            "Virginia",
            "Washington",
            "West Virginia",
            "Wisconsin",
            "Wyoming"
            };

            List<string> activityLevels = new List<string>()
            {
                "inactive",
                "sedentary",
                "active",
                "extremely active",
            };

            this.ViewData["ActivityLevels"] = activityLevels;
            this.ViewData["States"] = states;

            return this.View();
        }

        /// <summary>
        /// Submits user's survey if criteria was met with inputs
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult NewSurvey(Survey model)
        {
            if (this.ModelState.IsValid)
            {
                this.surveyDao.SaveNewSurvey(model);

                // Redirect browser to Index
                return this.RedirectToAction("Index");
            }

            return this.View("NewSurvey");
        }

    }
}