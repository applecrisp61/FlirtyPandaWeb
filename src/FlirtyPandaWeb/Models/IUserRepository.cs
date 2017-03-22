using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlirtyPandaWeb.Models {

    public interface IUserRepository {

        IEnumerable<User> Users { get; }

    }
}
