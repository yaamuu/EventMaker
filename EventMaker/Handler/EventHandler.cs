using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using EventMaker.Common;
using EventMaker.Conventer;
using EventMaker.Model;
using EventMaker.ViewModel;

namespace EventMaker.Handler
{
    class EventHandler
    {
       
        public EventViewModel EventViewModel { get; }

        

        public EventHandler(EventViewModel eventView)
        {
            EventViewModel = eventView;
        }

        public void CreateEvent()
        {
            DateTime date = DateTimeConventer.ConverterDateTime(EventViewModel.Date, EventViewModel.Time);
            EventCatalogSingleton singleton = new EventCatalogSingleton();
            EventViewModel.Singleton.EventList.Add(new Event(EventViewModel.Id, EventViewModel.Name, EventViewModel.Description, EventViewModel.Place, date ));
        }

    }
}
