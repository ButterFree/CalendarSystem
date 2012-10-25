using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalendarSystem.Model {
  class iCalService : CalendarService {
    private List<Event> Events;

    public iCalService(){
      //Stuff
    }

    public override List<Event> GetEvents() {
      return Events;
    }

    public override void AddEvent(Event ev){
      Events.Add(ev);
    }

    public override List<Event> GetEvents(DateTime Begin, DateTime End) {
      return Events;
    }
  }
}