﻿using GroceryStoreCore.DTOs;

namespace GroceryStoreDomain.Services.Interfaces
{
    public interface IUserService
    {
        Task<string> GetUserRole(int userId);

        Task<UserWithoutPasswordDto> GetUser(string userEmail, string userPassword);

        Task<int> AddUser(UserDto user);

        Task<UserWithoutPasswordDto> GetUserById(int userId);

        Task RemoveAdminAccess(int userId);

        Task<List<UserDto>> GetAllAdmins();
    }
}
