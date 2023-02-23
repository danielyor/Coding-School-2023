using FuelStation.Model.Enums;

namespace FuelStation.Shared {
    public class LoginState {
        public EmployeeType? IsLoggedIn { get; set; } = null;
        public string Username { get; set; } = String.Empty;
        public string Password { get; set; } = String.Empty;
        public event Action? OnChange;

        public void SetLogin(EmployeeType? login, string user) {
            IsLoggedIn = login;
            Username = user;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() {
            OnChange?.Invoke();
        }
    }
}