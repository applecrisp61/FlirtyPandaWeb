using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlirtyPandaWeb.Models {

    public class Track {

        public string TrackID { get; }
        public string Name { get; }
        public string UserID { get; }

        public Track(string trackID, string name, string userID) {
            TrackID = trackID;
            Name = name;
            UserID = userID;
        }
    }
}
