using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls;
using EventMaker.Common;
using EventMaker.Conventer;
using EventMaker.Model;
using EventMaker.View;
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

        public async void CreateEvent()
        {
            
            DateTime date = DateTimeConventer.ConverterDateTime(EventViewModel.Date, EventViewModel.Time);
            if (EventViewModel.Name != null && EventViewModel.Description != null && EventViewModel.Place != null &&
                EventViewModel.Id.ToString() != null)
            {
              
                EventViewModel.Singleton.EventList.Add(new Event(EventViewModel.Id, EventViewModel.Name,
                    EventViewModel.Description, EventViewModel.Place, date));

            }
            else
            {
                

                var dialog = new MessageDialog("Please fill all the information");
                await dialog.ShowAsync();

                
            }
           
        }

        public void DeleteEvent()
        {
            EventViewModel.Singleton.EventList.Remove(EventViewModel.SelectedItem);


        }
    }
}
