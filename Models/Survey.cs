﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Web.Models
{
    public class Survey
    {
        /// <summary>
        /// Id associated with a survey
        /// </summary>
        public int SurveyId { get; set; }

        /// <summary>
        /// Code associated with a park
        /// </summary>
        [Required]
        [MinLength(3)]
        [MaxLength(10)]
        public string ParkCode { get; set; }

        /// <summary>
        /// A user email address
        /// </summary>
        [Required]
        [EmailAddress]
        [MaxLength(100)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// A user State
        /// </summary>
        [Required]
        [MaxLength(30)]
        public string State { get; set; }

        /// <summary>
        /// A user actiivty level
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string ActivityLevel { get; set; }
    }
}
