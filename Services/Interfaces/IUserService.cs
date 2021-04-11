using Services.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.Interfaces {
    public interface IUserService {

        Task<UserDTO> Create(UserDTO userDTO);
        Task<UserDTO> Update(UserDTO userDTO);
        Task Remove(Guid id);
        Task<UserDTO> Get(Guid id);
        Task<List<UserDTO>> Get();
        Task<List<UserDTO>> SearchByName(string name);
        Task<List<UserDTO>> SearchByEmail(string enail);
        Task<UserDTO> GetByEmail(string email);



    }
}
