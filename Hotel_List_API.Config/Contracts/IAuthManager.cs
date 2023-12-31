﻿using Hotel_List_API.Configuration.Models.User;
using Microsoft.AspNetCore.Identity;

namespace Hotel_List_API.Configuration.Contracts
{
    public interface IAuthManager
    {
        Task<IEnumerable<IdentityError>> Register(ApiUserDTO userDto);
        Task<AuthResponseDTO> Login(LoginDTO loginDTO);
        Task<string> CreateRefreshToken();
        Task<AuthResponseDTO> VerifyRefreshToken(AuthResponseDTO request);
    }
}
