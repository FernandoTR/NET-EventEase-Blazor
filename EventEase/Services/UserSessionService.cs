using EventEase.Models;

namespace EventEase.Services
{
    public class UserSessionService
    {
        public Registration? CurrentUser { get; private set; }

        public void SetUser(Registration registration)
        {
            CurrentUser = registration;
        }

        public void ClearUser()
        {
            CurrentUser = null;
        }

        public bool IsLoggedIn => CurrentUser != null;
    }
}
