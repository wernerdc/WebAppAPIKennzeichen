using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppAPIKennzeichen.Models;

namespace WebAppAPIKennzeichen.Data
{
    public class WebAppAPIKennzeichenContext : DbContext
    {
        public WebAppAPIKennzeichenContext (DbContextOptions<WebAppAPIKennzeichenContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppAPIKennzeichen.Models.KennzeichenInfo> KennzeichenInfo { get; set; } = default!;
    }
}
