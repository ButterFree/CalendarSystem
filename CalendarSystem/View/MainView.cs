using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CalendarSystem.Model;
using CalendarSystem;

namespace CalendarSystem {
  public partial class MainView : Form {
    private List<CalendarService> CalendarServices;
    private Controller controller;

    public MainView() {
      controller = Controller.GetInstance();
      CalendarServices = controller.GetCalendarServices();
      InitializeComponent();
    }
  }
}
