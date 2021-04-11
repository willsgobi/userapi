using Domain;
using Infra.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Infra.Context {
    public class ManageContext : DbContext {

        public ManageContext() {

        }

        public ManageContext(DbContextOptions<ManageContext> options) : base(options) {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseMySql(@"Server=localhost;Database=usermanager;Uid=root;Pwd=root;");
        }

        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder) {
            builder.ApplyConfiguration(new UserMap());
        }
             
    }
}
