using Asp.NetCoreToDoList.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Asp.NetCoreToDoList.Data.Seeds
{
  public  class ToDoListSeed:IEntityTypeConfiguration<ToDoList>
    {

        public void Configure(EntityTypeBuilder<ToDoList> builder)
        {
            builder.HasData(
                new ToDoList { Id = 1, TaskName = "Ders Çalış", TaskDescription = "Belirlediğin derslerin gerekli konularına çalış!" },
                new ToDoList { Id = 2, TaskName = "Alışveriş Yap", TaskDescription = "Belirlediğin ihtiyaçları satın al!" }
                );
        }
    }
}
