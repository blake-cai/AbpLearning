using System.Collections.Generic;
using Learning_phone.Roles.Dto;
using Learning_phone.Users.Dto;

namespace Learning_phone.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
