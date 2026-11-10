using System;
using System.Collections.Generic;
using System.Linq;
using JusAbPOS.Data;
using JusAbPOS.Domain;

namespace JusAbPOS.Services
{
    /// <summary>Users &amp; Roles. Administrators only - checked here, not just by hiding the menu item.</summary>
    public sealed class UserService
    {
        private readonly User actor;
        private readonly UserAdminRepository repo = new UserAdminRepository();

        public UserService(User actor)
        {
            if (actor == null) throw new ArgumentNullException("actor");
            this.actor = actor;
        }

        private void RequireAdmin()
        {
            if (actor.Role != UserRole.Admin) throw new UnauthorizedAccessException("Only administrators can manage users.");
        }

        public List<UserAccount> GetAll() { RequireAdmin(); return repo.GetAll(); }
        public List<RoleItem> GetRoles() { RequireAdmin(); return repo.GetRoles(); }

        public int Create(string username, string fullName, int roleId, string password)
        {
            RequireAdmin();
            username = (username ?? "").Trim();
            fullName = (fullName ?? "").Trim();
            if (username.Length < 3 || username.Length > 50) throw new ArgumentException("Username must be 3 to 50 characters.");
            if (!username.All(ch => char.IsLetterOrDigit(ch) || ch == '.' || ch == '_' || ch == '-'))
                throw new ArgumentException("Username may contain only letters, digits, '.', '_' and '-'.");
            ValidateName(fullName);
            if (roleId <= 0) throw new ArgumentException("Choose a role.");
            ValidatePassword(password);
            return repo.Create(username, fullName, roleId, password);
        }

        public void Update(int userId, string fullName, int roleId)
        {
            RequireAdmin();
            fullName = (fullName ?? "").Trim();
            ValidateName(fullName);
            if (roleId <= 0) throw new ArgumentException("Choose a role.");
            if (userId == actor.Id && roleId != (int)actor.Role)
                throw new InvalidOperationException("You cannot change your own role.");
            repo.Update(userId, fullName, roleId);
        }

        public void SetActive(int userId, bool active)
        {
            RequireAdmin();
            if (userId == actor.Id && !active) throw new InvalidOperationException("You cannot deactivate your own account.");
            repo.SetActive(userId, active);
        }

        public void ResetPassword(int userId, string password)
        {
            RequireAdmin();
            ValidatePassword(password);
            repo.ResetPassword(userId, password);
        }

        private static void ValidateName(string fullName)
        {
            if (fullName.Length == 0) throw new ArgumentException("Full name is required.");
            if (fullName.Length > 100) throw new ArgumentException("Full name must be 100 characters or fewer.");
        }

        private static void ValidatePassword(string password)
        {
            if (string.IsNullOrEmpty(password) || password.Length < 8 || password.Length > 100)
                throw new ArgumentException("The password must be 8 to 100 characters.");
            if (!password.Any(char.IsLetter) || !password.Any(char.IsDigit))
                throw new ArgumentException("The password must contain at least one letter and one number.");
        }
    }
}
