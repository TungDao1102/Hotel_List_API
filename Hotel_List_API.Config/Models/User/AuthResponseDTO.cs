﻿namespace Hotel_List_API.Configuration.Models.User
{
    public class AuthResponseDTO
    {
        public string UserID { get; set; }
        public string Token { get; set; }
        public string RefreshToken { get; set; }
    }
}
