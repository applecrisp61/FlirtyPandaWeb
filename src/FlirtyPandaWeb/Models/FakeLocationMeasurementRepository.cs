using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlirtyPandaWeb.Models {

    public class FakeLocationMeasurementRepository : ILocationMeasurementRepository {

        public IEnumerable<LocationMeasurement> LocationMeasurements => new List<LocationMeasurement> {

            new LocationMeasurement(
                locationMeasurementID: "a",
                userID: "a",
                trackID: "a",
                latitude: 47.6510,
                longitude: -122.3473,
                dateTimeStamp: new DateTime(2017, 3, 14, 11, 12, 34),
                provider: "FakeLocationMeasurementRepository",
                isFromMockProvider: true),

            new LocationMeasurement(
                locationMeasurementID: "b",
                userID: "a",
                trackID: "a",
                latitude: 47.6512,
                longitude: -122.3473,
                dateTimeStamp: new DateTime(2017, 3, 14, 11, 12, 35),
                provider: "FakeLocationMeasurementRepository",
                isFromMockProvider: true),

            new LocationMeasurement(
                locationMeasurementID: "c",
                userID: "a",
                trackID: "a",
                latitude: 47.6514,
                longitude: -122.3473,
                dateTimeStamp: new DateTime(2017, 3, 14, 11, 12, 36),
                provider: "FakeLocationMeasurementRepository",
                isFromMockProvider: true),

            new LocationMeasurement(
                locationMeasurementID: "d",
                userID: "a",
                trackID: "a",
                latitude: 47.6516,
                longitude: -122.3473,
                dateTimeStamp: new DateTime(2017, 3, 14, 11, 12, 37),
                provider: "FakeLocationMeasurementRepository",
                isFromMockProvider: true),

            new LocationMeasurement(
                locationMeasurementID: "e",
                userID: "a",
                trackID: "a",
                latitude: 47.6518,
                longitude: -122.3473,
                dateTimeStamp: new DateTime(2017, 3, 14, 11, 12, 38),
                provider: "FakeLocationMeasurementRepository",
                isFromMockProvider: true),

            new LocationMeasurement(
                locationMeasurementID: "f",
                userID: "a",
                trackID: "a",
                latitude: 47.6520,
                longitude: -122.3473,
                dateTimeStamp: new DateTime(2017, 3, 14, 11, 12, 39),
                provider: "FakeLocationMeasurementRepository",
                isFromMockProvider: true),

            new LocationMeasurement(
                locationMeasurementID: "g",
                userID: "a",
                trackID: "b",
                latitude: 47.6510,
                longitude: -122.3473,
                dateTimeStamp: new DateTime(2017, 3, 15, 11, 12, 34),
                provider: "FakeLocationMeasurementRepository",
                isFromMockProvider: true),

            new LocationMeasurement(
                locationMeasurementID: "h",
                userID: "a",
                trackID: "b",
                latitude: 47.6510,
                longitude: -122.3475,
                dateTimeStamp: new DateTime(2017, 3, 15, 11, 12, 35),
                provider: "FakeLocationMeasurementRepository",
                isFromMockProvider: true),

            new LocationMeasurement(
                locationMeasurementID: "i",
                userID: "a",
                trackID: "b",
                latitude: 47.6510,
                longitude: -122.3477,
                dateTimeStamp: new DateTime(2017, 3, 15, 11, 12, 36),
                provider: "FakeLocationMeasurementRepository",
                isFromMockProvider: true),

            new LocationMeasurement(
                locationMeasurementID: "j",
                userID: "b",
                trackID: "c",
                latitude: 47.6510,
                longitude: -122.3479,
                dateTimeStamp: new DateTime(2017, 3, 15, 11, 12, 37),
                provider: "FakeLocationMeasurementRepository",
                isFromMockProvider: true),

            new LocationMeasurement(
                locationMeasurementID: "k",
                userID: "b",
                trackID: "c",
                latitude: 47.6510,
                longitude: -122.3481,
                dateTimeStamp: new DateTime(2017, 3, 15, 11, 12, 38),
                provider: "FakeLocationMeasurementRepository",
                isFromMockProvider: true),

            new LocationMeasurement(
                locationMeasurementID: "l",
                userID: "b",
                trackID: "c",
                latitude: 47.6510,
                longitude: -122.3483,
                dateTimeStamp: new DateTime(2017, 3, 15, 11, 12, 39),
                provider: "FakeLocationMeasurementRepository",
                isFromMockProvider: true),

            new LocationMeasurement(
                locationMeasurementID: "m",
                userID: "b",
                trackID: "d",
                latitude: 47.6510,
                longitude: -122.3483,
                dateTimeStamp: new DateTime(2017, 3, 15, 11, 12, 39),
                provider: "FakeLocationMeasurementRepository",
                isFromMockProvider: true),

            new LocationMeasurement(
                locationMeasurementID: "n",
                userID: "b",
                trackID: "d",
                latitude: 47.6520,
                longitude: -122.3483,
                dateTimeStamp: new DateTime(2017, 3, 15, 11, 12, 49),
                provider: "FakeLocationMeasurementRepository",
                isFromMockProvider: true),

            new LocationMeasurement(
                locationMeasurementID: "o",
                userID: "b",
                trackID: "d",
                latitude: 47.6530,
                longitude: -122.3483,
                dateTimeStamp: new DateTime(2017, 3, 15, 11, 12, 59),
                provider: "FakeLocationMeasurementRepository",
                isFromMockProvider: true),

            new LocationMeasurement(
                locationMeasurementID: "p",
                userID: "b",
                trackID: "e",
                latitude: 47.6512,
                longitude: -122.3483,
                dateTimeStamp: new DateTime(2017, 3, 16, 11, 12, 42),
                provider: "FakeLocationMeasurementRepository",
                isFromMockProvider: true),

            new LocationMeasurement(
                locationMeasurementID: "q",
                userID: "b",
                trackID: "e",
                latitude: 47.6514,
                longitude: -122.3483,
                dateTimeStamp: new DateTime(2017, 3, 16, 11, 12, 43),
                provider: "FakeLocationMeasurementRepository",
                isFromMockProvider: true),
        };

    }
}
