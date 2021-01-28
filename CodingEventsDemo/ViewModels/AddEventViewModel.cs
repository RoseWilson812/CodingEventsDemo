﻿using CodingEventsDemo.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodingEventsDemo.ViewModels
{
    public class AddEventViewModel
    {
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [StringLength(500, ErrorMessage = "Description too long!")]
        public string Description { get; set; }
        
        [Required(ErrorMessage = "Location is required.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Must be between 2 and 100 characters")]
        public string Location { get; set; }

        [Required(ErrorMessage = "Number Attending is required")]
        [Range(0, 100000,ErrorMessage = "Must be number between 0 and 100,000")]
         public int NumAttending { get; set; }           

        [EmailAddress]
        public string ContactEmail { get; set; }
        public EventType Type { get; set; }
        public List<SelectListItem> EventTypes { get; set; } = new List<SelectListItem>
{
   new SelectListItem(EventType.Conference.ToString(), ((int)EventType.Conference).ToString()),
   new SelectListItem(EventType.Meetup.ToString(), ((int)EventType.Meetup).ToString()),
   new SelectListItem(EventType.Social.ToString(), ((int)EventType.Social).ToString()),
   new SelectListItem(EventType.Workshop.ToString(), ((int)EventType.Workshop).ToString())
};
    }
}
