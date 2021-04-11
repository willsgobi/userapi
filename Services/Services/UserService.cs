using AutoMapper;
using Core.Exceptions;
using Services.DTO;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Infra.Interfaces;
using Domain.Entities;

namespace Services.Services {
    public class UserService : IUserService {

        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;

        public UserService(IMapper mapper, IUserRepository userRepository) {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public async Task<UserDTO> Create(UserDTO userDTO) {
            var userExists = await _userRepository.GetByEmail(userDTO.Email);

            if (userExists != null)
                throw new DomainException("Usuário já cadastrado com este e-mail.");

            var user = _mapper.Map<User>(userDTO);
            user.Validate();

            var userCreated = await _userRepository.Create(user);

            return _mapper.Map<UserDTO>(userCreated);
        }

        public async Task<UserDTO> Get(Guid id) {
           
        }

        public async Task<List<UserDTO>> Get() {
        }

        public async Task<UserDTO> GetByEmail(string email) {
        }

        public async Task Remove(Guid id) {
        }

        public async Task<List<UserDTO>> SearchByEmail(string enail) {
        }

        public async Task<List<UserDTO>> SearchByName(string name) {
        }

        public async Task<UserDTO> Update(UserDTO userDTO) {
        }
    }
}
