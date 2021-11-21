using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication.DAL.Entities;



namespace WebApplication.DAL.EF
{
    public class HotelDbContext: DbContext
    {
        public HotelDbContext(DbContextOptions<HotelDbContext> options)
           : base(options)
        {
            Database.EnsureCreated();
        }
        public virtual DbSet<Room> Rooms { set; get; }
        public virtual DbSet<Guest> Guests { set; get; }
        public virtual DbSet<Category> Categories { set; get; }
        public virtual DbSet<CategoryData> CategoryDatas { set; get; }
        public virtual DbSet<Lodging> Lodgings { set; get; }
        public virtual DbSet<User> Users { set; get; }
    }
}
