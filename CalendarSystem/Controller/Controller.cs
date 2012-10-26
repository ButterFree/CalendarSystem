using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CalendarSystem.Model;

namespace CalendarSystem {
  class Controller {
    private static readonly Controller instance = new Controller(); //Singleton
    private MainView mainView = new MainView();
    private List<CalendarService> calendarServices = new List<CalendarService>();

    public static void Main() {
      Controller.GetInstance();
    }

    /// <summary>
    /// Private controller.
    /// Use GetInstance
    /// </summary>
    private Controller(){
      mainView.Show();
    }

    /// <summary>
    /// Get instance of singleton Controller
    /// </summary>
    /// <returns>Controller instance</returns>
    public static Controller GetInstance() {
      return instance;
    }

    /// <summary>
    /// Get a list of CalendarServices
    /// </summary>
    /// <returns>List of CalendarService</returns>
    public List<CalendarService> GetCalendarServices() {
      return calendarServices;
    }
  }
}
