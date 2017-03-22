using Microsoft.AspNetCore.Mvc;
using FlirtyPandaWeb.Models;

namespace FlirtyPandaWeb.Controllers {

    public class LocationMeasurementController : Controller {

        private ILocationMeasurementRepository repository;

        public LocationMeasurementController(ILocationMeasurementRepository repo) {
            repository = repo;
        }

        public ViewResult List() => View(repository.LocationMeasurements);

        
    }
}
