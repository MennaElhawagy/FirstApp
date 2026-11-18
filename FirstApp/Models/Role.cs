using System;
using System.Collections.Generic;

namespace FirstApp.Models;

public partial class Role
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? ShortName { get; set; }

    public virtual ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
}
