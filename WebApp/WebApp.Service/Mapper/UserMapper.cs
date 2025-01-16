﻿using WebApp.Domain.Entities;
using WebApp.Service.DTO;

namespace WebApp.Service.Mapper
{
    internal static class UserMapper
    {
        internal static User MapToUser(this UserDto userDto) =>
            new()
            {
                CreatedDate = userDto.CreatedDate,
                Email = userDto.Email,
                Name = userDto.Name,
                Password = userDto.Password,
                Role = userDto.Role,
            };
    }
}