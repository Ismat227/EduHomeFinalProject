using EduHome.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.DAL
{
    public class EduHomeContext : DbContext
    {
        public EduHomeContext(DbContextOptions<EduHomeContext> options) : base(options)
        {
        }
        public DbSet<Settings> Settings { get; set; }
        public DbSet<Socials> socials { get; set; }
        public DbSet<ContactAdress> contactAdresses { get; set; }
        public DbSet<ContactMessage> contactMessages { get; set; }

    }
}
