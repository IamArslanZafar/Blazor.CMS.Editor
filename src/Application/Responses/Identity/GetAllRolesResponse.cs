﻿using System.Collections.Generic;

namespace Blazor.CMS.Editor.Application.Responses.Identity
{
    public class GetAllRolesResponse
    {
        public IEnumerable<RoleResponse> Roles { get; set; }
    }
}