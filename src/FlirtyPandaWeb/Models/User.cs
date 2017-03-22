using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlirtyPandaWeb.Models {

    public struct User {
        public string UserID { get; }
        public string Name { get; }

        public User(string userID, string name) {
            UserID = userID;
            Name = name;
        }

    }
}
