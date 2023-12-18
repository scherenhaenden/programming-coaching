using ProgrammingCoaching.SOLID.Examples.AutoLeasing.Data.DummyData;
using ProgrammingCoaching.SOLID.Examples.AutoLeasing.Data.Models;

namespace ProgrammingCoaching.SOLID.Examples.AutoLeasing.FixedExample
{
    /// <summary>
    /// Manages user information.
    /// </summary>
    public class UserManager {
        private readonly List<UserModel> _users = new MockedModels().Users;

        /// <summary>
        /// Gets a user by their login name.
        /// </summary>
        /// <param name="userLogin">The login name of the user to retrieve.</param>
        /// <returns>The user model if found; otherwise, null.</returns>
        public UserModel? GetUser(string userLogin) {
        return _users.SingleOrDefault(x => x.Name == userLogin);
    }
    }
}