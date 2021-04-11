using Infra.Interfaces;
using Infra.Context;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories {
    public class UserRepository : BaseRepository<User>, IUserRepository {

        private readonly ManageContext _context;

        public UserRepository(ManageContext context) : base(context) {
            _context = context;
        }

        public async Task<User> GetByEmail(string email) {
            var user = await _context.Users.Where(x => x.Email.ToLower() == email.ToLower()).AsNoTracking().ToListAsync();

            return user.FirstOrDefault();
        }

        public async Task<List<User>> SearchByEmail(string email) {
            var allUsers = await _context.Users.Where(x => x.Email.ToLower().Contains(email.ToLower())).AsNoTracking().ToListAsync();

            return allUsers;
        }

        public async Task<List<User>> SearchByName(string name) {
            var allUsers = await _context.Users.Where(x => x.Name.ToLower().Contains(name.ToLower())).AsNoTracking().ToListAsync();

            return allUsers;
        }
    }
}
