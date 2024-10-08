﻿using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-SAKEGUU\\MSSQLSERVER03;Database=TraversalDB;Integrated Security=true;TrustServerCertificate=True;");
        }

        //public override int SaveChanges()
        //{
        //    var newGuide = ChangeTracker.Entries<Guide>()
        //        .Where(x => x.State == EntityState.Added)
        //        .Select(x => x.Entity)
        //        .ToList();

        //    var result = base.SaveChanges();

        //    foreach (var guide in newGuide) //sisteme yeni bir rehber eklendiğinde hesap oluşturulacak
        //    {
        //        Accounts.Add(new Account
        //        {
        //            AccountID = guide.GuideID,
        //            GuideID = guide.GuideID,
        //            Balance = 0
        //        });
        //    }

        //    base.SaveChanges();

        //    return result;
        //}

        public DbSet<About1> Abouts1 { get; set; }
        public DbSet<About2> Abouts2 { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactUs> ContactUses { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Feature1> Features1 { get; set; }
        public DbSet<Feature2> Features2 { get; set; }
        public DbSet<Guide> Guides { get; set; }
        public DbSet<Newsletter> Newsletters { get; set; }
        public DbSet<SubAbout> SubAbouts { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<Account> Accounts { get; set; }
    }
}
