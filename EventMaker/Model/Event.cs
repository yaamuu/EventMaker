using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMaker.Model
{
    class Event
    {
        private int Id;
        private string Name;
        private string Description;
        private string Place;
        private DateTime DateTime;

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
