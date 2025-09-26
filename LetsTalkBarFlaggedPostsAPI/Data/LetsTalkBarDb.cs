
using Microsoft.EntityFrameworkCore;    
using Microsoft.EntityFrameworkCore.SqlServer;


namespace LetsTalkBarFlaggedPostsAPI.Data
{
    public class LetsTalkBarDb: DbContext
    {
        public LetsTalkBarDb(DbContextOptions<LetsTalkBarDb> options) : base(options) { }
        
        
        public DbSet<Post> Posts { get; set; }
    }
}
