﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventMaker.Model;

namespace EventMaker.ViewModel
{
    class EventViewModel
    {
        public EventCatalogSingleton Singleton { get; set; }
        public EventViewModel()
        {
            Singleton = EventCatalogSingleton.GetInstance();
        }
    }
}
