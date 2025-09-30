using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyApp.Backend.Datas.Entities;

namespace MyApp.Backend.Context
{
    public class IdentityContext<TDbContext> : IdentityDbContext<LoginUser>
    {
    }
}
