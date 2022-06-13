﻿using Blazor.CMS.Editor.Application.Requests.Identity;
using Blazor.CMS.Editor.Shared.Wrapper;
using System.Threading.Tasks;

namespace Blazor.CMS.Editor.Client.Infrastructure.Managers.Identity.Account
{
    public interface IAccountManager : IManager
    {
        Task<IResult> ChangePasswordAsync(ChangePasswordRequest model);

        Task<IResult> UpdateProfileAsync(UpdateProfileRequest model);

        Task<IResult<string>> GetProfilePictureAsync(string userId);

        Task<IResult<string>> UpdateProfilePictureAsync(UpdateProfilePictureRequest request, string userId);
    }
}