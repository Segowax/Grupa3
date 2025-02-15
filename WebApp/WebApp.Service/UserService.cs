﻿using WebApp.Domain.Exceptions;
using WebApp.Repository.Repositories.Interfaces;
using WebApp.Service.DTO;
using WebApp.Service.Mapper;

namespace WebApp.Service
{
    internal class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task AddUser(UserDto userDto)
        {
            var user = userDto.MapToUser();
            await _userRepository.Add(user);
        }

        public async Task<UserDto> GetUser(int id)
        {
           var user =  await _userRepository.Get(id);     
           return user?.MapToEntity() ?? throw new NotFoundException("");
        }
    }
}
