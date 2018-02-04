﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMaker.Model
{
    class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Place { get; set; }
        public DateTime DateTime { get; set; }

        public Event(int id, string name, string description, string place, DateTime datetime)
        {
            Id = id;
            Name = name;
            Description = description;
            Place = place;
            DateTime = datetime;
        }

        public override string ToString()
        {
            return Id + Name + Description + Place + DateTime;
        }
    }
}