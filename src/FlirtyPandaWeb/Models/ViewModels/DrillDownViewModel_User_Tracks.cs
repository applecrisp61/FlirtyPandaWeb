using System.Collections.Generic;
using FlirtyPandaWeb.Models;

namespace FlirtyPandaWeb.Models.ViewModels {
    public class DrillDownViewModel_User_Tracks {

        public string UserID { get; set; }
        public User User { get; set; }
        public IEnumerable<Track> Tracks { get; set; }
        public IEnumerable<LocationMeasurement> LocationMeasurements { get; set; }
    }
}
