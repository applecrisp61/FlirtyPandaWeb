using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlirtyPandaWeb.Models {

    public struct LocationMeasurement {

        // required data elements
        public string LocationMeasurementID { get; }
        public string UserID { get; }
        public string TrackID { get; }
        public double Latitude { get; }
        public double Longitude { get; }
        public DateTime DateTimeStamp { get; }
        public string Provider { get; }
        public bool IsFromFakeProvider { get; }

        // optional data elements
        public double? Elevation { get; }
        public int? BuildingFloor { get; }
        public double? Speed { get; }
        public double? Bearing { get; }
        public double? HorizontalAccuracy { get; }
        public double? VerticalAccuracy { get; }

        public LocationMeasurement(
            string locationMeasurementID,
            string userID,
            string trackID,
            double latitude,
            double longitude,
            DateTime dateTimeStamp,
            string provider,
            bool isFromMockProvider,
            double? elevation = null,
            int? buildingFloor = null,
            double? speed = null,
            double? bearing = null,
            double? horizontalAccuracy = null,
            double? verticalAccuracy = null) {
            LocationMeasurementID = locationMeasurementID;
            UserID = userID;
            TrackID = trackID;
            Latitude = latitude;
            Longitude = longitude;
            DateTimeStamp = dateTimeStamp;
            Provider = provider;
            IsFromFakeProvider = isFromMockProvider;
            Elevation = elevation;
            BuildingFloor = buildingFloor;
            Speed = speed;
            Bearing = bearing;
            HorizontalAccuracy = horizontalAccuracy;
            VerticalAccuracy = verticalAccuracy;
        } 

    }
}
