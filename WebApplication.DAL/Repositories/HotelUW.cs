using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using WebApplication.DAL.EF;
using WebApplication.DAL.Entities;
using WebApplication.DAL.Interfaces;

namespace WebApplication.DAL.Repositories
{
    public class HotelUW : IHotelUW
    {
        private HotelDbContext db;
        private UserRepository userRepository;
        private RoomRepository roomRepository;
        private GuestRepository guestRepository;
        private LodgingRepository lodgingRepository;
        private CategoryRepository categoryRepository;
        private CategoryDataRepository categoryDataRepository;
        private bool disposed = false;
        public HotelUW(DbContextOptions<HotelDbContext> options)
        {
            db = new HotelDbContext(options);
        }
        public IRepository<Room> Rooms
        {
            get
            {
                if (roomRepository == null)
                {
                    roomRepository = new RoomRepository(db);
                }
                return roomRepository;
            }

        }
        public IRepository<Guest> Guests
        {
            get
            {
                if (guestRepository == null)
                {
                    guestRepository = new GuestRepository(db);
                }
                return guestRepository;
            }
        }
        public IRepository<Category> Categories
        {
            get
            {
                if (categoryRepository == null)
                {
                    categoryRepository = new CategoryRepository(db);
                }
                return categoryRepository;
            }
        }
        public IRepository<Lodging> Lodgings
        {
            get
            {
                if (lodgingRepository == null)
                {
                    lodgingRepository = new LodgingRepository(db);
                }
                return lodgingRepository;
            }
        }
        public IRepository<CategoryData> CategoryDatas
        {
            get
            {
                if (categoryDataRepository == null)
                {
                    categoryDataRepository = new CategoryDataRepository(db);
                }
                return categoryDataRepository;
            }
        }
        public IRepository<User> Users
        {
            get
            {
                if (userRepository == null)
                {
                    userRepository = new UserRepository(db);
                }
                return userRepository;
            }
        }
        public void Save()
        {
            this.db.SaveChanges();
        }
        public void Dispose()
        {
            if (!disposed)
            {
                db.Dispose();
                disposed = true;
            }
        }
    }
}
