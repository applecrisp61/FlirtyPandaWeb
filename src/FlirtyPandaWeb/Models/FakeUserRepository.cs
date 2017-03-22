using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlirtyPandaWeb.Models {
    public class FakeUserRepository : IUserRepository {

        public IEnumerable<User> Users => new List<User> {

            new User(
                userID: "a",
                name: "Ruhtra"),

            new User(
                userID: "b",
                name: "Lienad")
            
        };

    }
}

