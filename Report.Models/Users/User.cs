using Report.Models.Roles;

namespace Report.Models.Users
{
    public class User
    {
        public string Email { get; set; }

        public string Name { get; set; }

        public Role Role { get; set; }
    }
}
