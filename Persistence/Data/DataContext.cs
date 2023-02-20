﻿using Domain;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Activity> Activities { get; set; }

    }
}
