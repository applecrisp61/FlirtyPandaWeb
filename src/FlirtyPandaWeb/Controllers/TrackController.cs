using System.Linq;

using Microsoft.AspNetCore.Mvc;

using FlirtyPandaWeb.Models;
using FlirtyPandaWeb.Models.ViewModels;

namespace FlirtyPandaWeb.Controllers {
    public class TrackController : Controller {

        private ITrackRepository repository;
        private IUserRepository userRepository;
        private ILocationMeasurementRepository locationMeasurementRepository;

        public TrackController(ITrackRepository repo, IUserRepository users, ILocationMeasurementRepository measurements) {
            repository = repo;
            userRepository = users;
            locationMeasurementRepository = measurements;
        }

        public ViewResult List() => View(repository.Tracks);

        public ViewResult ShiftView() => List();

        public ViewResult DrillDown(string userID) {
            var user = this.userRepository.Users.FirstOrDefault(u => u.UserID == userID);
            var tracks = this.repository.Tracks.Where(t => t.UserID == userID);
            var locationMeasurements = this.locationMeasurementRepository.LocationMeasurements.Where(lm => lm.UserID == userID);
            return View(new DrillDownViewModel_User_Tracks {
                UserID = userID,
                User = user,
                Tracks = tracks,
                LocationMeasurements = locationMeasurements
            });
        }
    }
}
