using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CalendarSystem.Model;

namespace CalendarSystem {
  class Controller {
    private MainView mainView = new MainView();
    private List<CalendarService> calendarService = new List<CalendarService>();

    public Controller(){
       mainView.Show();
    }
  }
}
