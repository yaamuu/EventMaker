using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMaker.Model
{
    class EventCatalogSingleton
    {
        private static EventCatalogSingleton instance  ;
       public ObservableCollection<Event> EventList { get; set; }

        public EventCatalogSingleton()
        {
            EventList = new ObservableCollection<Event>();

            EventList.Add(new Event(1, "Event1", "First event", "place1", new DateTime(2018, 2, 10)));
            EventList.Add(new Event(2, "Event2", "secound event", "place2", new DateTime(2018, 3, 20)));
            EventList.Add(new Event(3, "Event3", "third event", "place3", new DateTime(2018, 5, 13)));
        }

        public static EventCatalogSingleton GetInstance()
        {
            
            
                if (instance == null)
                {
                    instance = new EventCatalogSingleton();
                }
                return instance;
            
        }
        
    }
}
