using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalendarSystem.Model {
  interface CalendarService {

    public void AddEvent (Event);
    public List<Event> GetEvents();
    public List<Event> GetEvents(DateTime, DateTime);
  }
}
