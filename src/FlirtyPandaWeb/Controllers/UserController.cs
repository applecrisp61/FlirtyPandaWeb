using Microsoft.AspNetCore.Mvc;
using FlirtyPandaWeb.Models;

namespace FlirtyPandaWeb.Controllers {
    public class UserController : Controller {

        private IUserRepository repository;

        public UserController(IUserRepository repo) {
            repository = repo;
        }

        public ViewResult List() => View(repository.Users);

        public ViewResult ShiftView => List();
    }
}
