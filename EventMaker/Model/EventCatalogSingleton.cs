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

            EventList.Add(new Event(1, "Marcins Birthday", "He is turning 22 ", "Dieselvej 2", new DateTime(2018, 5, 9,11,12,55)));
            EventList.Add(new Event(2, "Antonios Funeral", "Act sad", "Sandraekkerne 6", new DateTime(2018, 1, 7,10,33,53)));
            EventList.Add(new Event(3, "Drinks with Jamshid", "Get smashed", "Mulagins Pub", new DateTime(2018, 2, 4,7,12,33)));
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
