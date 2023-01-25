
using ImageUpload.Models;
using Microsoft.EntityFrameworkCore;

namespace ImageUpload.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }
        public DbSet<ImageModel> Images { get; set; }
        
    }
}
