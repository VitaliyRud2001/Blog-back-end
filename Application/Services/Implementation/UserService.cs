using Application.Dtos;
using Application.Services.Interface;
using AutoMapper;
using Infrastructure.GenericRepositories;
using Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Implementation
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _userRepository;
        private readonly IMapper _mapper;
        private readonly IImageService _imageService;
        public UserService(IRepository<User> userRepository,
            IMapper mapper, IImageService imageService)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _imageService = imageService;
        }

        public async Task<UserInformationDto> GetUserInfoById(int id)
        {
            var user = await _userRepository.FindByCondition(user => user.Id == id);
            var mappedUser = _mapper.Map<UserInformationDto>(user);
            return mappedUser;
        }
    }
}
