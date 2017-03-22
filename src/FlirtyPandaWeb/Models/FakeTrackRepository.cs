using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlirtyPandaWeb.Models {
    public class FakeTrackRepository : ITrackRepository {

        public IEnumerable<Track> Tracks => new List<Track> {

            new Track(
                trackID: "a",
                name: "Fake track #1", 
                userID: "a"),

            new Track(
                trackID: "b",
                name: "Fake track #2",
                userID: "a"),

            new Track(
                trackID: "c",
                name: "Fake track #3",
                userID: "b"),

            new Track(
                trackID: "d",
                name: "Fake track #4",
                userID: "b"),

            new Track(
                trackID: "e",
                name: "Fake track #5",
                userID: "b")
        };

    }
}
