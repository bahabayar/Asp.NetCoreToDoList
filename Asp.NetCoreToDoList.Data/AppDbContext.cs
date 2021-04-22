using Asp.NetCoreToDoList.Core.Models;
using Asp.NetCoreToDoList.Data.Seeds;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Asp.NetCoreToDoList.Data
{
  public  class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<ToDoList> ToDoLists { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ToDoList>().HasKey(x => x.Id);
            modelBuilder.Entity<ToDoList>().Property(x => x.Id).UseIdentityColumn();
            modelBuilder.Entity<ToDoList>().Property(x => x.TaskName).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<ToDoList>().Property(x => x.TaskDescription).IsRequired().HasMaxLength(500);

            modelBuilder.ApplyConfiguration(new ToDoListSeed());
        }
    }
}
