﻿using Microsoft.EntityFrameworkCore;


namespace TheirDayBlazorApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<EventModel> Events { get; set; }   
    }
}
