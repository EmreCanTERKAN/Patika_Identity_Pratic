using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Patika_Identity_Pratic.Data
{
    public class PraticDbContext  : IdentityDbContext<IdentityUser>
    {

        public PraticDbContext(DbContextOptions<PraticDbContext> option) : base(option)
        {
            
        }


    }
}
