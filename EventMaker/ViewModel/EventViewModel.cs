﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using EventMaker.Annotations;
using EventMaker.Common;
using EventMaker.Model;

namespace EventMaker.ViewModel
{
    class EventViewModel:INotifyPropertyChanged
    {
       public int Id { get; }
        public string Name { get; }
        public string Description { get; }
        public string Place { get; }
        public DateTimeOffset Date { get; }
        public TimeSpan Time { get; }
        public Handler.EventHandler EventHandler { get; set; }
        private ICommand _createEventCommand;

        public ICommand CreateEventCommand
        {
            get { return _createEventCommand; }
            set { _createEventCommand = value; }
        }

        public EventCatalogSingleton Singleton { get; set; }
        public EventViewModel()
        {
            Singleton = EventCatalogSingleton.GetInstance();
            DateTime dt = System.DateTime.Now;
            Date = new DateTimeOffset(dt.Year,dt.Month,dt.Day,0,0,0,0,new TimeSpan());
            Time = new TimeSpan(dt.Hour, dt.Minute, dt.Second);
            EventHandler = new Handler.EventHandler(this);
            RelayCommand createCommand = new RelayCommand(EventHandler.CreateEvent);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}