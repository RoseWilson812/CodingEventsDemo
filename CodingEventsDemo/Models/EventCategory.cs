﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingEventsDemo.Models
{
    public class EventCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public EventCategory()
        {

        }
        public EventCategory(string name)
        {
            Name = name;
        }
    }
}





