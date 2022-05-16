using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksManager.Data.Entities;

namespace TasksManager.Data.Configurations
{

     /* 
     * Configuration Type for the POCO Class Tasks.  Controls Table Name, 
     * Columns Name, Types and Keys. 
     */
    public class TasksItemEntityConfiguration :
        IEntityTypeConfiguration<TaskItem>
    {
       /** Implementation of the Abstact Configure method that defines the configuration 
       * for the Tasks Table Object in the DB, and will be the one called when running the 
       * EF Migration command. **/
        public void Configure(EntityTypeBuilder<TaskItem> builder)
        {
            builder.ToTable("Tasks");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Title)
                .HasColumnType("varchar(150)");

            builder.Property(t => t.Description)
                .HasColumnType("varchar(250)");

            builder.Property(t => t.IsCompleted)
                .HasColumnType("Bit");
        }
    }
}
