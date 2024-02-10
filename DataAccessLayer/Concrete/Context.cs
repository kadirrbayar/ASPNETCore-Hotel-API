using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context: IdentityDbContext<DbUser,DbRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=KADIR\\SQLEXPRESS;initial catalog=HotelApi;integrated security=True");
        }

        public DbSet<Room>? Rooms { get; set; }
        public DbSet<Service>? Services { get; set; }
        public DbSet<Staff>? Staffs { get; set; }
        public DbSet<Subscribe>? Subscribes { get; set; }
        public DbSet<Testimonial>? Testimonials { get; set; }
        public DbSet<About>? Abouts { get; set; }
        public DbSet<Tutorial>? Tutorials { get; set; }
        public DbSet<Booking>? Bookings { get; set; }
        public DbSet<Contact>? Contacts { get; set; }
        public DbSet<Guest>? Guests { get; set; }
    }
}
